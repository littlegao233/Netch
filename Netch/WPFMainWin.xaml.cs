using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Server = Netch.Models.Server;

namespace Netch
{
    /// <summary>
    /// WPFMainWin.xaml 的交互逻辑
    /// </summary>
    public partial class WPFMainWin : MaterialDesignExtensions.Controls.MaterialWindow
    {
        public WPFMainWin()
        {
            InitializeComponent();
            MainViewModel viewModel = new MainViewModel();
            viewModel.GetServers();
            this.DataContext = viewModel;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //string get = ((DataGrid)sender).SelectedCells.First().Item.ToString() ;
            string get = ((DataGrid)sender).SelectedItem.ToString();
            SelectCellContent.Text = get;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Model> serversData;
        public ObservableCollection<Model> ServersData
        {
            get { return serversData; }
            set { serversData = value; RaisePropertyChanged(); }
        }
        public void GetServers()
        {
            ServersData = new ObservableCollection<Model>();
            foreach (var server in Global.Settings.Server.ToArray())
            {
                ServersData.Add(new Model()
                {
                    Remark = server.Remark,
                    Hostname = server.Hostname,
                    Delay = server.Delay,
                    OBFS = server.OBFS,
                    OBFSParam = server.OBFSParam,
                    QUICSecret = server.QUICSecret,
                    QUICSecure = server.QUICSecure,
                    AlterID = server.AlterID,
                    Country = server.Country,
                    EncryptMethod = server.EncryptMethod,
                    FakeType = server.FakeType,
                    Group = server.Group,
                    Host = server.Host,
                    Path = server.Path,
                    Plugin = server.Plugin,
                    Password = server.Password,
                    PluginOption = server.PluginOption,
                    Port = server.Port,
                    Protocol = server.Protocol,
                    Rate = server.Rate,
                    ProtocolParam = server.ProtocolParam,
                    TransferProtocol = server.TransferProtocol,
                    Type = server.Type,
                    UserID = server.UserID,
                    Username = server.Username,
                    TLSSecure = server.TLSSecure,
                    UseMux = server.UseMux
                });
            }
        }
    }
    public class Model : ViewModelBase
    {
        /// <summary>
        ///     备注
        /// </summary>
        private string remark;
        public string Remark
        {
            get { return remark; }
            set { remark = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     组
        /// </summary>
        private string group = "None";
        public string Group
        {
            get { return group; }
            set { group = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     代理类型（HTTP、HTTPS、Socks5、SS、SSR、VMess）
        /// </summary>
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     倍率
        /// </summary>
        private double rate = 1.0;
        public double Rate
        {
            get { return rate; }
            set { rate = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     地址
        /// </summary>
        private string hostname;
        public string Hostname
        {
            get { return hostname; }
            set { hostname = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     端口
        /// </summary>
        private int port;
        public int Port
        {
            get { return port; }
            set { port = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     账号（HTTP、HTTPS、Socks5）
        /// </summary>
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     密码（HTTP、HTTPS、Socks5、SS、SSR）
        /// </summary>
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		用户 ID（VMess）
        /// </summary>
        private string userID = string.Empty;
        public string UserID
        {
            get { return userID; }
            set { userID = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		额外 ID（VMess）
        /// </summary>
        private int alterID = 0;
        public int AlterID
        {
            get { return alterID; }
            set { alterID = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     加密方式（SS、SSR、VMess）
        /// </summary>
        private string encryptMethod;
        public string EncryptMethod
        {
            get { return encryptMethod; }
            set { encryptMethod = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     插件（SS）
        /// </summary>
        private string plugin;
        public string Plugin
        {
            get { return plugin; }
            set { plugin = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     插件参数（SS）
        /// </summary>
        private string pluginOption;
        public string PluginOption
        {
            get { return pluginOption; }
            set { pluginOption = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     协议（SSR）
        /// </summary>
        private string protocol;
        public string Protocol
        {
            get { return protocol; }
            set { protocol = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     协议参数（SSR）
        /// </summary>
        private string protocolParam;
        public string ProtocolParam
        {
            get { return protocolParam; }
            set { protocolParam = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     混淆（SSR）
        /// </summary>
        private string oBFS;
        public string OBFS
        {
            get { return oBFS; }
            set { oBFS = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     混淆参数（SSR）
        /// </summary>
        private string oBFSParam;
        public string OBFSParam
        {
            get { return oBFSParam; }
            set { oBFSParam = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		传输协议（VMess）
        /// </summary>
        private string transferProtocol = "tcp";
        public string TransferProtocol
        {
            get { return transferProtocol; }
            set { transferProtocol = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		伪装类型（VMess）
        /// </summary>
        private string fakeType = string.Empty;
        public string FakeType
        {
            get { return fakeType; }
            set { fakeType = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		伪装域名（VMess：HTTP、WebSocket、HTTP/2）
        /// </summary>
        private string host = string.Empty;
        public string Host
        {
            get { return host; }
            set { host = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		传输路径（VMess：WebSocket、HTTP/2）
        /// </summary>
        private string path = string.Empty;
        public string Path
        {
            get { return path; }
            set { path = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		QUIC 加密方式（VMess）
        /// </summary>
        private string qUICSecure = "none";
        public string QUICSecure
        {
            get { return qUICSecure; }
            set { qUICSecure = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		QUIC 加密密钥（VMess）
        /// </summary>
        private string qUICSecret = string.Empty;
        public string QUICSecret
        {
            get { return qUICSecret; }
            set { qUICSecret = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		TLS 底层传输安全（VMess）
        /// </summary>
        private bool tLSSecure = false;
        public bool TLSSecure
        {
            get { return tLSSecure; }
            set { tLSSecure = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///		Mux 多路复用（VMess）
        /// </summary>
        private bool useMux = false;
        public bool UseMux
        {
            get { return useMux; }
            set { useMux = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     延迟
        /// </summary>
        private int delay = -1;
        public int Delay
        {
            get { return delay; }
            set { delay = value; RaisePropertyChanged(); }
        }
        /// <summary>
        ///     地区
        /// </summary> 
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; RaisePropertyChanged(); }
        }
    }
}
