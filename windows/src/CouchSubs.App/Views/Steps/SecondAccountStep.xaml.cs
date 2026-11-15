// SPDX-License-Identifier: AGPL-3.0-only

using System.Windows;
using System.Windows.Controls;
using CouchSubs.Shell;

namespace CouchSubs.App.Views.Steps;

public partial class SecondAccountStep : UserControl
{
    public SecondAccountStep() => InitializeComponent();

    private AppController Controller => (AppController)DataContext;

    /// <summary>"İkinci hesap yok mu?": görüntü bu bilgisayardaki Remote Play penceresinden okunur, kurulum biter.</summary>
    private void OnUseRemotePlayWindow(object sender, RoutedEventArgs e) => Controller.UseRemotePlayWindow();
}
