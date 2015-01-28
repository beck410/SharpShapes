using System;
using sharpshapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Reflection;

namespace GrapeShapes {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      PopulateClassList();
    }

    private void PopulateClassList() {
      List<string> shapeClassList = new List<string>();
      Type shapeType = typeof(Shape);

      foreach (Type type in Assembly.GetAssembly(shapeType).GetTypes()) {
        if (type.IsSubclassOf(shapeType) && !type.IsAbstract) {
          shapeClassList.Add(type.Name);
        }
      }
      ShapeTypeComboBox.ItemsSource = shapeClassList;
    }

  }
}
