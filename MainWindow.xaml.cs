using Pluton;
using Pluton.WindowsSystemFeatures;
using System;
using System.IO;
using System.Windows;

namespace SysFunctionals {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void ShutdownClicked(object sender, RoutedEventArgs e) {
			statusUpdateLabel.Content = "Shutting down...";
			PTools.Shutdown(false);
		}

		private void RestartClicked(object sender, RoutedEventArgs e) {
			statusUpdateLabel.Content = "Restarting now";
			PTools.Shutdown(true);
		}

		private void ScreenshotClicked(object sender, RoutedEventArgs e) {
			string fileName = DateTime.Now.Ticks.ToString();
			PTools.Screenshot(fileName);
			statusUpdateLabel.Content = $"Screenshot saved @ {Directory.GetCurrentDirectory()} with name {fileName}";
		}

		private void UACClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.DisableUAC();
			statusUpdateLabel.Content = "UAC Disabled.";
		}

		private void DisableDefenderClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.WindowsDefender(false);
			statusUpdateLabel.Content = "Defender disabled.";
		}

		private void EnableDefenderClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.WindowsDefender(true);
			statusUpdateLabel.Content = "Defender enabled.";
		}

		private void DisableFirewallClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.Firewall(false);
			statusUpdateLabel.Content = "Firewall disabled.";
		}

		private void EnableFirewallClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.Firewall(true);
			statusUpdateLabel.Content = "Firewall enabled.";
		}

		private void DisableSmartScreenClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.SmartScreen(false);
			statusUpdateLabel.Content = "SmartScreen disabled.";
		}

		private void EnableSmartScreenClicked(object sender, RoutedEventArgs e) {
			PSecuritySystems.SmartScreen(true);
			statusUpdateLabel.Content = "SmartScreen enabled.";
		}

		private void HideTaskbarClicked(object sender, RoutedEventArgs e) {
			PDesktop.HideTaskBar();
			statusUpdateLabel.Content = "Taskbar hidden.";
		}

		private void ShowTaskbarClicked(object sender, RoutedEventArgs e) {
			PDesktop.ShowTaskBar();
			statusUpdateLabel.Content = "Taskbar shown.";
		}

		private void SetDarkThemeClicked(object sender, RoutedEventArgs e) {
			PDesktop.SetTheme(false);
			statusUpdateLabel.Content = "Dark theme set.";
		}

		private void SetLightThemeClicked(object sender, RoutedEventArgs e) {
			PDesktop.SetTheme(true);
			statusUpdateLabel.Content = "Light theme set.";
		}

		private void TurnOffInternetClicked(object sender, RoutedEventArgs e) {
			PNetwork.InternetConnection(false);
			statusUpdateLabel.Content = "Internet disabled.";
		}

		private void TurnOnInternetClicked(object sender, RoutedEventArgs e) {
			PNetwork.InternetConnection(true);
			statusUpdateLabel.Content = "Internet enabled.";
		}
	}
}
