using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamCSS
{
  class Program
  {
    [STAThread]
    static void Main()
    {
      try
      {
        var steamPath = File.ReadAllText("SteamPath.txt").Trim();
        var style = File.ReadAllText("Style.css");
        var cssFiles = File.ReadAllText("StylePath.txt").Trim().Split(new string [] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
        var processedFiles = new List<string>();
        cssFiles.ForEach(file =>
        {
          var filePath = Path.Combine(steamPath, file);
          if (!File.Exists(filePath))
          {
            return;
          }
          var content = File.ReadAllText(filePath);
          if (!content.StartsWith(style))
          {
            File.WriteAllText(filePath, style + Environment.NewLine + content);
            processedFiles.Add(filePath);
          }
        });
        var message = string.Join(Environment.NewLine, processedFiles);
        MessageBox.Show(string.IsNullOrWhiteSpace(message) ? "没有要处理的文件" : $"已处理:{Environment.NewLine}{message}", "SteamCSS", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (FileNotFoundException ex)
      {
        MessageBox.Show(ex.Message, "SteamCSS", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
