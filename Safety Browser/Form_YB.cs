﻿using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Safety_Browser
{
    public partial class Form_YB : Form
    {
        private string[] web_service = { "http://www.ssicortex.com/GetTxt2Search", "http://www.ssitectonic.com/GetTxt2Search", "http://www.ssihedonic.com/GetTxt2Search" };
        private string[] domain_service = { "http://www.ssicortex.com/GetDomains", "http://www.ssitectonic.com/GetText2Search", "http://www.ssihedonic.com/GetText2Search" };
        private string[] send_service = { "http://www.ssicortex.com/SendDetails", "http://www.ssitectonic.com/SendDetails", "http://www.ssihedonic.com/SendDetails" };
        private string text_search;
        private bool close = true;
        private bool isHijacked;
        private int current_domain_index = 0;
        private int total_domain_index;
        private int current_web_service = 0;
        private int current_domain = 0;
        private string domain_get;
        private bool last_index_hijacked_get = false;
        private bool networkIsAvailable;
        private bool completed = true;
        private bool timeout = true;
        private string webbrowser_handler_title;
        private Uri webbrowser_handler_url;
        private string replace_domain_get;
        private bool domain_one_time = true;
        private bool load_not_hijacked = false;
        private bool connection_handler = false;
        private string _mac_address;
        private string _external_ip;
        private string _city;
        private string _region;
        private string _country;
        private string BRAND_CODE = "YB";
        private string API_KEY = "6b8c7e5617414bf2d4ace37600b6ab71";
        private ChromiumWebBrowser chromeBrowser;
        private double defaultValue = 0;
        private GlobalKeyboardHook gHook;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int
             HTLEFT = 10,
             HTRIGHT = 11,
             HTTOP = 12,
             HTTOPLEFT = 13,
             HTTOPRIGHT = 14,
             HTBOTTOM = 15,
             HTBOTTOMLEFT = 16,
             HTBOTTOMRIGHT = 17;
        const int _ = 1; // you can rename this variable if you like
        new Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        new Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        new Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, ClientSize.Height); } }
        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        public bool IsMenuVisible { get; private set; }
        public bool IsCloseVisible { get; private set; }
        public bool not_hijacked = false;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public Form_YB()
        {
            InitializeComponent();
            InitializeChromium();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);

            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
            gHook.hook();
        }

        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (not_hijacked)
            {
                if (ContainsFocus)
                {
                    if (e.KeyData.ToString().ToUpper().IndexOf("Control".ToUpper()) >= 0 && e.KeyData.ToString().ToUpper().IndexOf("Shift".ToUpper()) >= 0 && e.KeyCode == Keys.R)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                chromeBrowser.Reload(false);
                            }));

                        }).Start();
                    } 
                    else if (e.KeyData.ToString().ToUpper().IndexOf("Control".ToUpper()) >= 0 && e.KeyCode == Keys.R)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                chromeBrowser.Reload(true);
                            }));

                        }).Start();
                    }
                    else if (e.KeyCode == Keys.Left)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                chromeBrowser.Back();
                            }));

                        }).Start();
                    }
                    else if (e.KeyCode == Keys.Right)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                chromeBrowser.Forward();
                            }));

                        }).Start();
                    }
                    else if (e.KeyData.ToString().ToUpper().IndexOf("Control".ToUpper()) >= 0 && e.KeyCode == Keys.D0)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                defaultValue = 0;
                                chromeBrowser.SetZoomLevel(0);
                            }));

                        }).Start();
                    }
                    else if (e.KeyData.ToString().ToUpper().IndexOf("Control".ToUpper()) >= 0 && e.KeyCode == Keys.Oemplus)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                chromeBrowser.SetZoomLevel(++defaultValue);
                            }));

                        }).Start();
                    }
                    else if (e.KeyData.ToString().ToUpper().IndexOf("Control".ToUpper()) >= 0 && e.KeyCode == Keys.OemMinus)
                    {
                        new Thread(() =>
                        {
                            Invoke(new Action(delegate
                            {
                                chromeBrowser.SetZoomLevel(--defaultValue);
                            }));

                        }).Start();
                    }
                }
            }
        }

        // Form Load
        private void Form_Main_Load(object sender, EventArgs e)
        {
            NetworkAvailability();
            #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            GetTextToTextAsync(web_service[current_web_service]);
            #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            PictureBoxCenter();
        }

        // Network Handler
        private void NetworkAvailability()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface nic in nics)
            {
                if (
                    (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.NetworkInterfaceType != NetworkInterfaceType.Tunnel) &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    networkIsAvailable = true;
                }
            }

            if (networkIsAvailable)
            {
                GetIPInfo();
            }
            else
            {
                timer_handler.Stop();

                panel_cefsharp.Visible = false;
                pictureBox_loader.Visible = false;

                panel_connection.Visible = true;
                panel_connection.Enabled = true;
            }

            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler(NetworkChange_NetworkAvailabilityChanged);
        }

        // Network Handler Changed
        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            Invoke(new Action(() =>
            {
                networkIsAvailable = e.IsAvailable;

                if (networkIsAvailable)
                {
                    if (dataGridView_domain.RowCount == 0 && last_index_hijacked_get)
                    {
                        if (current_web_service < web_service.Length)
                        {
                            ByPassCalling();
                        
                            panel_connection.Visible = false;
                            panel_connection.Enabled = false;
                        }
                        else
                        {
                            panel_connection.Visible = false;
                            panel_connection.Enabled = false;

                            panel_cefsharp.Visible = false;
                            pictureBox_loader.Visible = false;
                        }
                    }
                    else if (dataGridView_domain.RowCount == 0 && !connection_handler)
                    {
                        #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                        GetTextToTextAsync(web_service[current_web_service]);
                        #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

                        panel_connection.Visible = false;
                        panel_connection.Enabled = false;

                        panel_cefsharp.Visible = false;
                        pictureBox_loader.Visible = false;
                    }
                    else if (!last_index_hijacked_get)
                    {
                        panel_connection.Visible = false;
                        panel_connection.Enabled = false;
                        pictureBox_loader.Visible = false;
                        
                        panel_cefsharp.Visible = true;
                    }
                    else
                    {
                        panel_cefsharp.Visible = false;
                        panel_connection.Visible = false;
                        panel_connection.Enabled = false;

                        if (panel_cefsharp.Visible == true)
                        {
                            pictureBox_loader.Visible = false;
                        }
                        else
                        {
                            if (!connection_handler)
                            {
                                pictureBox_loader.Visible = true;
                            }
                            else
                            {
                                panel_cefsharp.Visible = true;
                            }
                        }

                        if (!connection_handler)
                        {
                            dataGridView_domain.ClearSelection();
                            dataGridView_domain.Rows[current_domain_index].Selected = true;
                        }
                    }
                }
                else
                {
                    webBrowser_handler.Stop();
                    timer_handler.Stop();

                    panel_cefsharp.Visible = false;
                    pictureBox_loader.Visible = false;

                    panel_connection.Visible = true;
                    panel_connection.Enabled = true;
                }
            }));
        }

        // Loader Center
        private void PictureBoxCenter()
        {
            pictureBox_loader.Left = (ClientSize.Width - pictureBox_loader.Width) / 2;
            pictureBox_loader.Top = (ClientSize.Height - pictureBox_loader.Height) / 2;

            panel_connection.Left = (ClientSize.Width - panel_connection.Width) / 2;
            panel_connection.Top = (ClientSize.Height - panel_connection.Height) / 2;
        }

        // Get Text to Search
        private async Task GetTextToTextAsync(string web_service_test)
        {
            if (networkIsAvailable)
            {
                label_current_web_service.Text = web_service_test;

                try
                {
                    var client = new HttpClient();
                    var requestContent = new FormUrlEncodedContent(new[] {
                        new KeyValuePair<string, string>("api_key", API_KEY),
                        new KeyValuePair<string, string>("brand_code", BRAND_CODE),
                    });

                    HttpResponseMessage response = await client.PostAsync(
                        web_service_test,
                        requestContent);

                    if (!response.IsSuccessStatusCode)
                    {
                        text_search = "";
                        close = true;
                        current_domain_index = 0;
                        total_domain_index = 0;

                        dataGridView_domain.DataSource = null;
                        current_web_service++;
                        current_domain++;

                        if (current_web_service < web_service.Length)
                        {
                            ByPassCalling();
                        }
                        else
                        {
                            pictureBox_loader.Visible = false;
                            pictureBox_loader.Enabled = false;
                            connection_handler = true;
                        }

                        return;
                    }

                    HttpContent responseContent = response.Content;

                    using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                    {
                        string json = await reader.ReadToEndAsync();
                        string pattern = @"\[(.*?)\]";
                        var matches = Regex.Matches(json, pattern);

                        foreach (Match m in matches)
                        {
                            text_search = Regex.Unescape(m.Groups[1].ToString().Replace("\"", ""));
                        }

                        if (!String.IsNullOrEmpty(text_search))
                        {
                            // Get Domains
                            await GetDomainsAsync(domain_service[current_domain]);
                            total_domain_index = dataGridView_domain.RowCount;
                            dataGridView_domain.ClearSelection();
                            dataGridView_domain.Rows[current_domain_index].Selected = true;
                            domain_one_time = true;
                        }
                        else
                        {
                            text_search = "";
                            close = true;
                            current_domain_index = 0;
                            total_domain_index = 0;

                            dataGridView_domain.DataSource = null;
                            current_web_service++;
                            current_domain++;

                            if (current_web_service < web_service.Length)
                            {
                                ByPassCalling();
                            }
                            else
                            {
                                pictureBox_loader.Visible = false;
                                pictureBox_loader.Enabled = false;
                                connection_handler = true;
                            }
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("There is a problem with the server! Please contact IT support. \n\nError Message: " + err.Message + "\nError Code: 1001", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    close = false;
                    Close();
                }
            }
            else
            {
                timer_handler.Stop();

                panel_cefsharp.Visible = false;
                pictureBox_loader.Visible = false;

                panel_connection.Visible = true;
                panel_connection.Enabled = true;
            }
        }

        // ByPass Calling
        private void ByPassCalling()
        {
            #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            GetTextToTextAsync(web_service[current_web_service]);
            #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        // Get Domain
        private async Task GetDomainsAsync(string test_domain)
        {
            label_current_domain_service.Text = test_domain;

            try
            {
                var client = new HttpClient();
                var requestContent = new FormUrlEncodedContent(new[] {
                    new KeyValuePair<string, string>("api_key", API_KEY),
                    new KeyValuePair<string, string>("brand_code", BRAND_CODE),
                });

                HttpResponseMessage response = await client.PostAsync(
                    test_domain,
                    requestContent);

                HttpContent responseContent = response.Content;

                using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                {
                    string json = await reader.ReadToEndAsync();
                    string pattern = @"\[(.*?)\]";
                    var matches = Regex.Matches(json, pattern);
                    string domain_get = string.Empty;

                    foreach (Match m in matches)
                    {
                        domain_get = Regex.Unescape(m.Groups[1].ToString().Replace("\"", ""));
                    }


                    StringBuilder sb = new StringBuilder(domain_get);
                    sb.Replace("domain_ur", "");
                    sb.Replace("\"", "");
                    sb.Replace("l:", "");
                    sb.Replace("{", "");
                    sb.Replace("}", "");
                    
                    var elements = sb.ToString().Split(new[]
                    { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string items in elements)
                    {
                        dataGridView_domain.Rows.Add(items);
                    }

                    //int count = jArray.Count;
                    //int i = 0;

                    //while (i < count)
                    //{
                    //    string get = jArray[i]["domain_name"].Value<string>();
                    //    dataGridView_domain.ClearSelection();
                    //    dataGridView_domain.Rows.Add(get);
                    //    i++;
                    //}
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("There is a problem with the server! Please contact IT support. \n\nError Message: " + err.Message + "\nError Code: 1002", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        
        // Domain Selection Changed
        private void DataGridView_domain_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_domain.CurrentCell == null || dataGridView_domain.CurrentCell.Value == null)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView_domain.SelectedRows)
                {
                    try
                    {
                        domain_get = row.Cells[0].Value.ToString();

                        panel_cefsharp.Visible = false;

                        pictureBox_loader.Visible = true;

                        timer_handler.Stop();
                        timer_handler.Start();

                        completed = true;
                        timeout = true;

                        webBrowser_handler.Navigate(domain_get);
                    }
                    catch (Exception)
                    {
                        // Leave blank
                    }
                }
            }
        }

        // asd123
        // Web Browser Loaded
        private void WebBrowser_handler_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (domain_one_time)
            {
                if (completed)
                {
                    if (webBrowser_handler.ReadyState == WebBrowserReadyState.Complete)
                    {
                        if (e.Url == webBrowser_handler.Url)
                        {
                            // handlers
                            webbrowser_handler_title = webBrowser_handler.DocumentTitle;
                            webbrowser_handler_url = webBrowser_handler.Url;
                            timeout = false;
                            timer_handler.Stop();

                            string strValue = text_search;
                            string[] strArray = strValue.Split(',');

                            foreach (string obj in strArray)
                            {
                                bool contains = webbrowser_handler_title.Contains(obj);

                                if (contains == true)
                                {
                                    Invoke(new Action(() =>
                                    {
                                        isHijacked = false;
                                    }));

                                    break;
                                }
                                else if (!contains)
                                {
                                    Invoke(new Action(() =>
                                    {
                                        isHijacked = true;
                                    }));
                                }
                            }

                            if (isHijacked)
                            {
                                var html = "";

                                if (!domain_get.Contains("http"))
                                {
                                    try
                                    {
                                        replace_domain_get = "http://" + domain_get;
                                        html = new WebClient().DownloadString(replace_domain_get);
                                    }
                                    catch (Exception)
                                    {
                                        html = "";
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        html = new WebClient().DownloadString(domain_get);
                                    }
                                    catch (Exception)
                                    {
                                        html = "";
                                    }
                                }

                                if (html.Contains("landing_image"))
                                {
                                    domain_one_time = false;
                                    last_index_hijacked_get = false;
                                    pictureBox_loader.Visible = false;
                                    panel_cefsharp.Visible = true;
                                    not_hijacked = true;

                                    chromeBrowser.Load(domain_get);
                                }
                                else
                                {
                                    last_index_hijacked_get = true;
                                    not_hijacked = false;
                                    label_loadingstate.Text = "1";
                                    label_loadingstate.Text = "0";
                                }
                            }
                            else
                            {
                                domain_one_time = false;
                                last_index_hijacked_get = false;
                                pictureBox_loader.Visible = false;
                                panel_cefsharp.Visible = true;
                                not_hijacked = true;

                                chromeBrowser.Load(domain_get);
                            }
                        }
                    }
                }
            }
            else if (load_not_hijacked)
            {
                // handlers
                if (webBrowser_handler.ReadyState == WebBrowserReadyState.Complete)
                {
                    if (e.Url == webBrowser_handler.Url)
                    {
                        pictureBox_loader.Visible = false;
                        panel_cefsharp.Visible = true;
                        load_not_hijacked = false;
                    }
                }
            }
        }

        // Timeout
        private void Timer_handler_Tick(object sender, EventArgs e)
        {
            if (domain_one_time)
            {
                if (timeout)
                {
                    // handlers
                    webbrowser_handler_title = webBrowser_handler.DocumentTitle;
                    webbrowser_handler_url = webBrowser_handler.Url;
                    completed = false;
                    webBrowser_handler.Stop();
                    timer_handler.Stop();

                    string strValue = text_search;
                    string[] strArray = strValue.Split(',');

                    foreach (string obj in strArray)
                    {
                        bool contains = webbrowser_handler_title.Contains(obj);

                        if (contains == true)
                        {
                            Invoke(new Action(() =>
                            {
                                isHijacked = false;
                            }));

                            break;
                        }
                        else if (!contains)
                        {
                            Invoke(new Action(() =>
                            {
                                isHijacked = true;
                            }));
                        }
                    }

                    if (isHijacked)
                    {
                        var html = "";

                        if (!domain_get.Contains("http"))
                        {
                            try
                            {
                                replace_domain_get = "http://" + domain_get;
                                html = new WebClient().DownloadString(replace_domain_get);
                            }
                            catch (Exception)
                            {
                                html = "";
                            }
                        }
                        else
                        {
                            try
                            {
                                html = new WebClient().DownloadString(domain_get);
                            }
                            catch (Exception)
                            {
                                html = "";
                            }
                        }

                        if (html.Contains("landing_image"))
                        {
                            domain_one_time = false;
                            last_index_hijacked_get = false;
                            pictureBox_loader.Visible = false;
                            panel_cefsharp.Visible = true;

                            chromeBrowser.Load(domain_get);
                        }
                        else
                        {
                            last_index_hijacked_get = true;
                            label_loadingstate.Text = "1";
                            label_loadingstate.Text = "0";
                        }
                    }
                    else
                    {
                        domain_one_time = false;
                        last_index_hijacked_get = false;
                        pictureBox_loader.Visible = false;
                        panel_cefsharp.Visible = true;

                        chromeBrowser.Load(domain_get);
                    }
                }
            }
            else if (load_not_hijacked)
            {
                webBrowser_handler.Stop();
                timer_handler.Stop();

                pictureBox_loader.Visible = false;
                panel_cefsharp.Visible = true;
                load_not_hijacked = false;
            }
        }

        // Initialize Chromium
        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            //settings.CefCommandLineArgs.Add("ppapi-flash-path", @"C:\WINDOWS\SysWOW64\Macromed\Flash\pepflashplayer32_18_0_0_209.dll"); //Load a specific pepper flash version (Step 1 of 2)
            //settings.CefCommandLineArgs.Add("ppapi-flash-version", "18.0.0.209"); //Load a specific pepper flash version (Step 2 of 2)
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser();
            chromeBrowser.MenuHandler = new CustomMenuHandler();
            //chromeBrowser.LifeSpanHandler = new BrowserLifeSpanHandler();
            panel_cefsharp.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }
        
        // Loading State Changed
        private void Label_loadingstate_TextChanged(object sender, EventArgs e)
        {
            if (label_loadingstate.Text == "0")
            {
                current_domain_index = dataGridView_domain.SelectedRows[0].Index + 1;
                
                if (current_domain_index == total_domain_index)
                {
                    if (domain_one_time)
                    {
                        domain_one_time = false;
                        text_search = "";
                        close = true;
                        current_domain_index = 0;
                        total_domain_index = 0;

                        dataGridView_domain.Rows.Clear();
                        dataGridView_domain.Refresh();

                        current_web_service++;
                        current_domain++;

                        if (current_web_service < web_service.Length)
                        {
                            #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                            GetTextToTextAsync(web_service[current_web_service]);
                            #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                        }
                        else
                        {
                            pictureBox_loader.Visible = false;
                            pictureBox_loader.Enabled = false;
                            connection_handler = true;
                        }
                    }
                }
                else
                {
                    dataGridView_domain.FirstDisplayedScrollingRowIndex = current_domain_index;
                    dataGridView_domain.ClearSelection();
                    dataGridView_domain.Rows[current_domain_index].Selected = true;
                }
            }
        }
        // Form Closing
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to exit the program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Cef.Shutdown();
                }
            }
            else
            {
                Cef.Shutdown();
            }
        }

        // Get external IP
        private string GetExternalIp()
        {
            try
            {
                string externalIP;
                externalIP = (new WebClient()).DownloadString("https://canihazip.com/s");
                externalIP = (new Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                             .Matches(externalIP)[0].ToString();
                
                return externalIP;
            }
            catch (Exception err)
            {
                MessageBox.Show("There is a problem! Please contact IT support. \n\nError Message: " + err.Message + "\nError Code: RC1000", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Get MAC Address
        public static string GetMACAddress()
        {
            try
            {
                string macAddress = string.Empty;
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                        nic.OperationalStatus == OperationalStatus.Up && !nic.Name.Contains("Tunnel") && !nic.Name.Contains("VirtualBox") && !nic.Name.Contains("Adapter") && !nic.Description.Contains("Npcap") && !nic.Description.Contains("Loopback"))
                        macAddress += nic.GetPhysicalAddress().ToString();
                }

                return macAddress;
            }
            catch (Exception err)
            {
                MessageBox.Show("There is a problem! Please contact IT support. \n\nError Message: " + err.Message + "\nError Code: RC1000", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Get IP Info
        private void GetIPInfo()
        {
            try
            {
                var API_PATH_IP_API = "http://ip-api.com/json/" + GetExternalIp();

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    client.BaseAddress = new Uri(API_PATH_IP_API);
                    HttpResponseMessage response = client.GetAsync(API_PATH_IP_API).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode)
                    {
                        var locationDetails = response.Content.ReadAsAsync<IpInfo>().GetAwaiter().GetResult();
                        if (locationDetails != null)
                        {
                            _mac_address = GetMACAddress();
                            _external_ip = GetExternalIp();
                            _city = locationDetails.city.Replace("'", "''");
                            _country = locationDetails.country.Replace("'", "''");
                            //MessageBox.Show(_mac_address + "\n" + _external_ip + "\n" + _city + "\n" + _country);
                            //InsertDevice(send_service[current_web_service], _external_ip, _mac_address, _city, _country);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("There is a problem! Please contact IT support. \n\nError Message: " + err.Message + "\nError Code: 1000", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertDevice(string domain, string ip, string mac_address, string city, string country)
        {
            try
            {
                using (var wb = new WebClient())
                {
                    var data = new NameValueCollection
                    {
                        ["api_key"] = API_KEY,
                        ["brand_code"] = BRAND_CODE,
                        ["ip"] = ip,
                        ["macid"] = mac_address,
                        ["city"] = city,
                        ["country"] = country
                    };

                    var response = wb.UploadValues(domain, "POST", data);
                    string responseInString = Encoding.UTF8.GetString(response);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("There is a problem with the server! Please contact IT support. \n\nError Message: " + err.Message + "\nError Code: 1003", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                close = false;
                Close();
            }
        }

        private void IPExists(string ip)
        {

        }

        private void pictureBox_minimize_MouseHover(object sender, EventArgs e)
        {
            pictureBox_minimize.BackColor = Color.FromArgb(197, 112, 53);
        }

        private void pictureBox_minimize_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_minimize.BackColor = Color.FromArgb(235, 99, 6);
        }

        private void pictureBox_maximize_MouseHover(object sender, EventArgs e)
        {
            pictureBox_maximize.BackColor = Color.FromArgb(197, 112, 53);
        }

        private void pictureBox_maximize_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_maximize.BackColor = Color.FromArgb(235, 99, 6);
        }

        private void pictureBox_close_MouseHover(object sender, EventArgs e)
        {
            if (!IsCloseVisible)
            {
                pictureBox_close.BackColor = Color.FromArgb(197, 112, 53);
            }
        }

        private void pictureBox_close_MouseLeave(object sender, EventArgs e)
        {
            if (!IsCloseVisible)
            {
                pictureBox_close.BackColor = Color.FromArgb(235, 99, 6);
            }
        }

        private void pictureBox_menu_MouseHover(object sender, EventArgs e)
        {
            Point position = new Point(pictureBox_menu.Left, pictureBox_menu.Height);
            ToolStripMenuItem.DropDown.Show(pictureBox_menu, position);

            pictureBox_hover.BackColor = Color.FromArgb(197, 112, 53);
            pictureBox_menu.BackColor = Color.FromArgb(197, 112, 53);
        }

        private void pictureBox_menu_MouseLeave(object sender, EventArgs e)
        {
            if (!IsMenuVisible)
            {
                pictureBox_hover.BackColor = Color.FromArgb(235, 99, 6);
                pictureBox_menu.BackColor = Color.FromArgb(235, 99, 6);
            }
        }

        private void pictureBox_hover_MouseHover(object sender, EventArgs e)
        {
            Point position = new Point(pictureBox_menu.Left, pictureBox_menu.Height);
            ToolStripMenuItem.DropDown.Show(pictureBox_menu, position);

            pictureBox_hover.BackColor = Color.FromArgb(197, 112, 53);
            pictureBox_menu.BackColor = Color.FromArgb(197, 112, 53);
        }

        private void pictureBox_hover_MouseLeave(object sender, EventArgs e)
        {
            if (!IsMenuVisible)
            {
                pictureBox_hover.BackColor = Color.FromArgb(235, 99, 6);
                pictureBox_menu.BackColor = Color.FromArgb(235, 99, 6);
            }
        }

        private void pictureBox_menu_Click(object sender, EventArgs e)
        {
            Point position = new Point(pictureBox_menu.Left, pictureBox_menu.Height);
            ToolStripMenuItem.DropDown.Show(pictureBox_menu, position);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (close)
            {
                IsCloseVisible = true;
                pictureBox_menu.BackColor = Color.FromArgb(197, 112, 53);
                pictureBox_hover.BackColor = Color.FromArgb(197, 112, 53);

                DialogResult dr = MessageBox.Show("Are you sure you want to exit the program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Environment.Exit(0);
                    Cef.Shutdown();
                }
                else
                {
                    IsCloseVisible = false;
                    pictureBox_menu.BackColor = Color.FromArgb(235, 99, 6);
                    pictureBox_hover.BackColor = Color.FromArgb(235, 99, 6);
                }
            }
            else
            {
                Environment.Exit(0);
                Cef.Shutdown();
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                chromeBrowser.Reload(true);
            }
        }
        private void cleanAndReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                chromeBrowser.Reload(false);
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                chromeBrowser.SetZoomLevel(++defaultValue);
            }
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                chromeBrowser.SetZoomLevel(--defaultValue);
            }
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                defaultValue = 0;
                chromeBrowser.SetZoomLevel(0);
            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                chromeBrowser.Back();
            }
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (not_hijacked)
            {
                chromeBrowser.Forward();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string asd = String.Empty;
            string asdText = Application.OpenForms.Count.ToString();
            //label1.Text = "";
            foreach (Form frm in Application.OpenForms)
            {
                asd += frm.Name + "\n";
            }
            MessageBox.Show(asdText);
            MessageBox.Show(asd);
        }

        private void pictureBox_hover_Click(object sender, EventArgs e)
        {
            Point position = new Point(pictureBox_menu.Left, pictureBox_menu.Height);
            ToolStripMenuItem.DropDown.Show(pictureBox_menu, position);
        }
        
        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            if (close)
            {
                IsCloseVisible = true;
                pictureBox_close.BackColor = Color.FromArgb(197, 112, 53);

                DialogResult dr = MessageBox.Show("Are you sure you want to exit the program?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Environment.Exit(0);
                    Cef.Shutdown();
                }
                else
                {
                    IsCloseVisible = false;
                    pictureBox_close.BackColor = Color.FromArgb(235, 99, 6);
                }
            }
            else
            {
                Environment.Exit(0);
                Cef.Shutdown();
            }
        }
         
        private void label_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks >= 2)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush defaultColor = new SolidBrush(Color.FromArgb(235, 99, 6));
            e.Graphics.FillRectangle(defaultColor, Top);
            e.Graphics.FillRectangle(defaultColor, Left);
            e.Graphics.FillRectangle(defaultColor, Right);
            e.Graphics.FillRectangle(defaultColor, Bottom);
        }  
        
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }
    }
}

