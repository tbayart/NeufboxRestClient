namespace NeufboxRestClient.Constants
{
    /// <summary>
    /// API methods.
    /// </summary>
    public static class ApiMethod
    {
        /// <summary>
        /// getToken method, part of authentication module.
        /// </summary>
        public const string AuthGetToken = ApiModule.Auth + ".getToken";

        /// <summary>
        /// checkToken method, part of authentication module.
        /// </summary>
        public const string AuthCheckToken = ApiModule.Auth + ".checkToken";

        /// <summary>
        /// Not Implemented (Yet)
        /// 
        /// backup3g.forceDataLink
        /// backup3g.forceVoipLink
        /// backup3g.getPinCode
        /// backup3g.setPinCode
        /// ddns.disable
        /// ddns.enable
        /// ddns.forceUpdate
        /// ddns.getInfo
        /// ddns.setService
        /// dsl.getInfo
        /// ftth.getInfo
        /// firewall.enableSmtpFilter
        /// firewall.disableSmtpFilter
        /// firewall.getInfo
        /// hotspot.enable
        /// hotspot.disable
        /// hotspot.getClientList
        /// hotspot.getInfo
        /// hotspot.setMode
        /// hotspot.restart
        /// hotspot.start
        /// hotspot.stop
        /// lan.addDnsHost
        /// lan.deleteDnsHost
        /// lan.getDnsHostList
        /// lan.getHostsList
        /// lan.getInfo
        /// ont.getInfo
        /// ont.sync
        /// ont.push
        /// ont.pull
        /// p910nd.getInfo
        /// ppp.getCredentials
        /// ppp.getInfo
        /// ppp.setCredentials
        /// smb.getInfo
        /// system.getInfo
        /// system.getIfList
        /// system.getWpaKey
        /// system.reboot
        /// system.setNetMode
        /// system.setRefClient
        /// tv.getInfo
        /// usb.getInfo
        /// voip.getCallhistoryList
        /// voip.getInfo
        /// voip.restart
        /// voip.start
        /// voip.stop
        /// wan.getInfo
        /// wlan.enable
        /// wlan.disable
        /// wlan.getClientList
        /// wlan.getInfo
        /// wlan.getScanList
        /// wlan.setChannel
        /// wlan.setWl0Enc
        /// wlan.setWl0Enctype
        /// wlan.setWl0Keytype
        /// wlan.setWl0Ssid
        /// wlan.setWl0Wepkey
        /// wlan.setWl0Wpakey
        /// wlan.setWlanMode
        /// wlan.start
        /// wlan.stop
        /// wlan.restart
        /// wlan5.getClientList
        /// wlan5.getInfo
        /// wlan5.setChannel
        /// wlan5.setWl0Enc
        /// wlan5.setWl0Enctype
        /// wlan5.setWl0Keytype
        /// wlan5.setWl0Ssid
        /// wlan5.setWl0Wepkey
        /// wlan5.setWl0Wpakey
        /// wlan5.setWlanMode
        /// guest.getInfo
        /// guest.enable
        /// guest.disable
        /// guest.setSsid
        /// guest.setWpakey
        /// </summary>
    }

    /// <summary>
    /// API modules.
    /// </summary>
    public static class ApiModule
    {
        /// <summary>
        /// The authentication domain.
        /// </summary>
        public const string Auth = "auth";

        /// <summary>
        /// The backup3g domain.
        /// </summary>
        public const string Backup3g = "backup3g";

        /// <summary>
        /// The ddns domain.
        /// </summary>
        public const string DDNS = "ddns";

        /// <summary>
        /// The dsl domain.
        /// </summary>
        public const string DSL = "dsl";

        /// <summary>
        /// The ftth domain.
        /// </summary>
        public const string FTTH = "ftth";

        /// <summary>
        /// The firewall domain.
        /// </summary>
        public const string Firewall = "firewall";

        /// <summary>
        /// The hotspot domain.
        /// </summary>
        public const string Hotspot = "hotspot";

        /// <summary>
        /// The lan domain.
        /// </summary>
        public const string LAN = "lan";

        /// <summary>
        /// The ont domain.
        /// </summary>
        public const string ONT = "ont";

        /// <summary>
        /// The p910nd domain.
        /// </summary>
        public const string P910ND = "p910nd";

        /// <summary>
        /// The ppp domain.
        /// </summary>
        public const string PPP = "ppp";

        /// <summary>
        /// The smb domain.
        /// </summary>
        public const string SMB = "smb";

        /// <summary>
        /// The system domain.
        /// </summary>
        public const string System = "system";

        /// <summary>
        /// The tv domain.
        /// </summary>
        public const string TV = "tv";

        /// <summary>
        /// The usb domain.
        /// </summary>
        public const string USB = "usb";

        /// <summary>
        /// The voip domain.
        /// </summary>
        public const string VOIP = "voip";

        /// <summary>
        /// The wan domain.
        /// </summary>
        public const string WAN = "wan";

        /// <summary>
        /// The wlan domain.
        /// </summary>
        public const string WLAN = "wlan";

        /// <summary>
        /// The wlan5 domain.
        /// </summary>
        public const string WLAN5 = "wlan5";

        /// <summary>
        /// The guest domain.
        /// </summary>
        public const string Guest = "guest";
    }
}
