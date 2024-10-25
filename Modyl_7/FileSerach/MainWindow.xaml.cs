using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;  
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileSerach
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Обработчик для кнопки "Search"
        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string searchPattern = txtSearchPattern.Text;

                if (string.IsNullOrEmpty(searchPattern))
                {
                    MessageBox.Show("Введите ключевое слово для поиска.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                lstFiles.Items.Clear(); // Очистка списка перед новым поиском
                progressBar.Visibility = Visibility.Visible;
                progressBar.Value = 0;

                var drives = DriveInfo.GetDrives().Where(d => d.IsReady).ToList();
                int totalDrives = drives.Count;
                int processedDrives = 0;

                foreach (var drive in drives)
                {
                    await Task.Run(() => SearchFilesInDirectory(drive.RootDirectory.FullName, searchPattern));
                    processedDrives++;
                    progressBar.Value = (double)processedDrives / totalDrives * 100;
                }

                progressBar.Visibility = Visibility.Hidden;

                if (lstFiles.Items.Count == 0)
                {
                    MessageBox.Show("Файлы не найдены.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Метод для поиска файлов в директориях (итеративный)
        private void SearchFilesInDirectory(string rootDirectory, string searchPattern)
        {
            Queue<string> directories = new Queue<string>();
            directories.Enqueue(rootDirectory);

            while (directories.Count > 0)
            {
                string currentDirectory = directories.Dequeue();

                try
                {
                    // Поиск файлов в текущей директории
                    var files = Directory.GetFiles(currentDirectory, $"*{searchPattern}*", SearchOption.TopDirectoryOnly);
                    foreach (var file in files)
                    {
                        Dispatcher.Invoke(() => lstFiles.Items.Add(file)); // Добавление файла в список
                    }

                    // Добавление всех подпапок в очередь для последующего поиска
                    var subDirs = Directory.GetDirectories(currentDirectory);
                    foreach (var dir in subDirs)
                    {
                        directories.Enqueue(dir);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    // Пропуск директори, если доступ запрещен
                }
                catch (Exception ex)
                {
                    Dispatcher.Invoke(() => MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error));
                }
            }
        }

        // Обработчик для кнопки "Delete Selected"
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstFiles.SelectedItem != null)
            {
                try
                {
                    string selectedFile = lstFiles.SelectedItem.ToString();

                    // Удаление выбранного файла
                    if (File.Exists(selectedFile))
                    {
                        File.Delete(selectedFile);
                        MessageBox.Show("Файл успешно удалён.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                        lstFiles.Items.Remove(selectedFile); // Удаление из списка
                    }
                    else
                    {
                        MessageBox.Show("Файл не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show("Ошибка при удалении файла (нет доступа): " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении файла: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите файл для удаления.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
    
