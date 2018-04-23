using System.Windows;
using DevExpress.Xpf.Core;
using DXExample.DemoData;

namespace DXTabControl_RestrictingSelection {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {
            tabControl.ItemsSource = Invoice.GetData();
        }
        private void tabControl_SelectionChanging(object sender,
            TabControlSelectionChangingEventArgs e) {
            if (!((Invoice)tabControl.Items[e.NewSelectedIndex]).IsUrgent)
                e.Cancel = true;
        }
    }
}