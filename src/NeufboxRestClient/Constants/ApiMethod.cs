namespace NeufboxRestClient.Constants
{
    /// <summary>
    /// API methods.
    /// </summary>
    public static class ApiMethod
    {
        /// <summary>
        /// The authentication module.
        /// </summary>
        public static class Auth
        {
            /// <summary>
            /// getToken method.
            /// </summary>
            public const string GetToken = "auth.getToken";

            /// <summary>
            /// checkToken method.
            /// </summary>
            public const string CheckToken = "auth.checkToken";
        }

        /// <summary>
        /// The backup3g module.
        /// </summary>
        public static class Backup3g
        {
            /// <summary>
            /// forceDataLink method.
            /// </summary>
            public const string ForceDataLink = "backup3g.forceDataLink";

            /// <summary>
            /// forceVoipLink method.
            /// </summary>
            public const string ForceVoipLink = "backup3g.forceVoipLink";

            /// <summary>
            /// getPinCode method.
            /// </summary>
            public const string GetPinCode = "backup3g.getPinCode";

            /// <summary>
            /// setPinCode method.
            /// </summary>
            public const string SetPinCode = "backup3g.setPinCode";
        }

        /// <summary>
        /// The ddns module.
        /// </summary>
        public static class DDNS
        {
            /// <summary>
            /// disable method.
            /// </summary>
            public const string Disable = "ddns.disable";

            /// <summary>
            /// enable method.
            /// </summary>
            public const string Enable = "ddns.enable";

            /// <summary>
            /// forceUpdate method.
            /// </summary>
            public const string ForceUpdate = "ddns.forceUpdate";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "ddns.getInfo";

            /// <summary>
            /// setService method.
            /// </summary>
            public const string SetService = "ddns.setService";
        }

        /// <summary>
        /// The dsl module.
        /// </summary>
        public static class DSL
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "dsl.getInfo";
        }

        /// <summary>
        /// The ftth module.
        /// </summary>
        public static class FTTH
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "ftth.getInfo";
        }

        /// <summary>
        /// The firewall module.
        /// </summary>
        public static class Firewall
        {
            /// <summary>
            /// enableSmtpFilter method.
            /// </summary>
            public const string EnableSmtpFilter = "firewall.enableSmtpFilter";

            /// <summary>
            /// disableSmtpFilter method.
            /// </summary>
            public const string DisableSmtpFilter = "firewall.disableSmtpFilter";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "firewall.getInfo";
        }

        /// <summary>
        /// The hotspot module.
        /// </summary>
        public static class Hotspot
        {
            /// <summary>
            /// enable method.
            /// </summary>
            public const string Enable = "hotspot.enable";

            /// <summary>
            /// disable method.
            /// </summary>
            public const string Disable = "hotspot.disable";

            /// <summary>
            /// getClientList method.
            /// </summary>
            public const string GetClientList = "hotspot.getClientList";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "hotspot.getInfo";

            /// <summary>
            /// setMode method.
            /// </summary>
            public const string SetMode = "hotspot.setMode";

            /// <summary>
            /// restart method.
            /// </summary>
            public const string Restart = "hotspot.restart";

            /// <summary>
            /// start method.
            /// </summary>
            public const string Start = "hotspot.start";

            /// <summary>
            /// stop method.
            /// </summary>
            public const string Stop = "hotspot.stop";
        }

        /// <summary>
        /// The lan module.
        /// </summary>
        public static class LAN
        {
            /// <summary>
            /// addDnsHost method.
            /// </summary>
            public const string AddDnsHost = "lan.addDnsHost";

            /// <summary>
            /// deleteDnsHost method.
            /// </summary>
            public const string DeleteDnsHost = "lan.deleteDnsHost";

            /// <summary>
            /// getDnsHostList method.
            /// </summary>
            public const string GetDnsHostList = "lan.getDnsHostList";

            /// <summary>
            /// getHostsList method.
            /// </summary>
            public const string GetHostsList = "lan.getHostsList";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "lan.getInfo";
        }

        /// <summary>
        /// The ont module.
        /// </summary>
        public static class ONT
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "ont.getInfo";

            /// <summary>
            /// sync method.
            /// </summary>
            public const string Sync = "ont.sync";

            /// <summary>
            /// push method.
            /// </summary>
            public const string Push = "ont.push";

            /// <summary>
            /// pull method.
            /// </summary>
            public const string Pull = "ont.pull";
        }

        /// <summary>
        /// The p910nd module.
        /// </summary>
        public static class P910ND
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "p910nd.getInfo";
        }

        /// <summary>
        /// The ppp module.
        /// </summary>
        public static class PPP
        {
            /// <summary>
            /// getCredentials method.
            /// </summary>
            public const string GetCredentials = "ppp.getCredentials";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "ppp.getInfo";

            /// <summary>
            /// setCredentials method.
            /// </summary>
            public const string SetCredentials = "ppp.setCredentials";
        }

        /// <summary>
        /// The smb module.
        /// </summary>
        public static class SMB
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "smb.getInfo";
        }

        /// <summary>
        /// The system module.
        /// </summary>
        public static class System
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "system.getInfo";

            /// <summary>
            /// getIfList method.
            /// </summary>
            public const string GetIfList = "system.getIfList";

            /// <summary>
            /// getWpaKey method.
            /// </summary>
            public const string GetWpaKey = "system.getWpaKey";

            /// <summary>
            /// reboot method.
            /// </summary>
            public const string Reboot = "system.reboot";

            /// <summary>
            /// setNetMode method.
            /// </summary>
            public const string SetNetMode = "system.setNetMode";

            /// <summary>
            /// setRefClient method.
            /// </summary>
            public const string SetRefClient = "system.setRefClient";
        }

        /// <summary>
        /// The tv module.
        /// </summary>
        public static class TV
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "tv.getInfo";
        }

        /// <summary>
        /// The usb module.
        /// </summary>
        public static class USB
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string getInfo = "usb.getInfo";
        }

        /// <summary>
        /// The voip module.
        /// </summary>
        public static class VOIP
        {
            /// <summary>
            /// getCallhistoryList method.
            /// </summary>
            public const string GetCallhistoryList = "voip.getCallhistoryList";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "voip.getInfo";

            /// <summary>
            /// restart method.
            /// </summary>
            public const string Restart = "voip.restart";

            /// <summary>
            /// start method.
            /// </summary>
            public const string Start = "voip.start";

            /// <summary>
            /// stop method.
            /// </summary>
            public const string Stop = "voip.stop";
        }

        /// <summary>
        /// The wan module.
        /// </summary>
        public static class WAN
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "wan.getInfo";
        }

        /// <summary>
        /// The wlan module.
        /// </summary>
        public static class WLAN
        {
            /// <summary>
            /// enable method.
            /// </summary>
            public const string Enable = "wlan.enable";

            /// <summary>
            /// disable method.
            /// </summary>
            public const string Disable = "wlan.disable";

            /// <summary>
            /// getClientList method.
            /// </summary>
            public const string GetClientList = "wlan.getClientList";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "wlan.getInfo";

            /// <summary>
            /// getScanList method.
            /// </summary>
            public const string GetScanList = "wlan.getScanList";

            /// <summary>
            /// setChannel method.
            /// </summary>
            public const string SetChannel = "wlan.setChannel";

            /// <summary>
            /// setWl0Enc method.
            /// </summary>
            public const string SetWl0Enc = "wlan.setWl0Enc";

            /// <summary>
            /// setWl0Enctype method.
            /// </summary>
            public const string SetWl0Enctype = "wlan.setWl0Enctype";

            /// <summary>
            /// setWl0Keytype method.
            /// </summary>
            public const string SetWl0Keytype = "wlan.setWl0Keytype";

            /// <summary>
            /// setWl0Ssid method.
            /// </summary>
            public const string SetWl0Ssid = "wlan.setWl0Ssid";

            /// <summary>
            /// setWl0Wepkey method.
            /// </summary>
            public const string SetWl0Wepkey = "wlan.setWl0Wepkey";

            /// <summary>
            /// setWl0Wpakey method.
            /// </summary>
            public const string SetWl0Wpakey = "wlan.setWl0Wpakey";

            /// <summary>
            /// setWlanMode method.
            /// </summary>
            public const string SetWlanMode = "wlan.setWlanMode";

            /// <summary>
            /// start method.
            /// </summary>
            public const string Start = "wlan.start";

            /// <summary>
            /// stop method.
            /// </summary>
            public const string Stop = "wlan.stop";

            /// <summary>
            /// restart method.
            /// </summary>
            public const string Sestart = "wlan.restart";
        }

        /// <summary>
        /// The wlan5 module.
        /// </summary>
        public static class WLAN5
        {
            /// <summary>
            /// getClientList method.
            /// </summary>
            public const string GetClientList = "wlan5.getClientList";

            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "wlan5.getInfo";

            /// <summary>
            /// setChannel method.
            /// </summary>
            public const string SetChannel = "wlan5.setChannel";

            /// <summary>
            /// setWl0Enc method.
            /// </summary>
            public const string SetWl0Enc = "wlan5.setWl0Enc";

            /// <summary>
            /// setWl0Enctype method.
            /// </summary>
            public const string SetWl0Enctype = "wlan5.setWl0Enctype";

            /// <summary>
            /// setWl0Keytype method.
            /// </summary>
            public const string SetWl0Keytype = "wlan5.setWl0Keytype";

            /// <summary>
            /// setWl0Ssid method.
            /// </summary>
            public const string SetWl0Ssid = "wlan5.setWl0Ssid";

            /// <summary>
            /// setWl0Wepkey method.
            /// </summary>
            public const string SetWl0Wepkey = "wlan5.setWl0Wepkey";

            /// <summary>
            /// setWl0Wpakey method.
            /// </summary>
            public const string SetWl0Wpakey = "wlan5.setWl0Wpakey";

            /// <summary>
            /// setWlanMode method.
            /// </summary>
            public const string SetWlanMode = "wlan5.setWlanMode";
        }

        /// <summary>
        /// The guest module.
        /// </summary>
        public static class Guest
        {
            /// <summary>
            /// getInfo method.
            /// </summary>
            public const string GetInfo = "guest.getInfo";

            /// <summary>
            /// enable method.
            /// </summary>
            public const string Enable = "guest.enable";

            /// <summary>
            /// disable method.
            /// </summary>
            public const string Disable = "guest.disable";

            /// <summary>
            /// setSsid method.
            /// </summary>
            public const string SetSsid = "guest.setSsid";

            /// <summary>
            /// setWpakey method.
            /// </summary>
            public const string SetWpakey = "guest.setWpakey";
        }
    }
}
