﻿namespace TokenDump.Interop
{
    internal class Capabilities
    {
        /*
         * Based On:
         * https://github.com/googleprojectzero/sandbox-attacksurface-analysis-tools/blob/c7ca3db6c2fb59eec3bceb4d5a731821f84f663a/NtApiDotNet/SecurityCapabilities.cs
         */
        public static readonly string[] KnownCapabilityNames = {
            "ID_CAP_ACCESSIBILITY_CLIENT",
            "ID_CAP_ACCESS_FAMILY_NOTES_API",
            "ID_CAP_ACCESS_REMINDER_IMAGES",
            "ID_CAP_ACC_MGR_ADMIN",
            "ID_CAP_ADAPTIVE_BRIGHTNESS_CONTROL",
            "ID_CAP_ADVERTISING_CONFIG",
            "ID_CAP_AIS_TOKEN_MANAGER",
            "ID_CAP_APPCONTAINER_PACKAGE_CERTIFICATES",
            "ID_CAP_APPOINTMENTS",
            "ID_CAP_APPPREINSTALL_DIRECTORY",
            "ID_CAP_APPPREINSTALL_EVENTS",
            "ID_CAP_APPRESOLVER",
            "ID_CAP_APPX_EXECUTION",
            "ID_CAP_APP_STORE_PURCHASE_HISTORY",
            "ID_CAP_AUDIO_EVENTSND",
            "ID_CAP_AUDIO_INTERNAL",
            "ID_CAP_AUDIO_ROUTING_CONTROLLER",
            "ID_CAP_AUDIO_SETTINGS",
            "ID_CAP_AUTHHOST",
            "ID_CAP_BACKGROUND_EXECUTION_MANAGEMENT",
            "ID_CAP_BACKGROUND_SETTINGS_MANAGEMENT",
            "ID_CAP_BACKGROUND_WORKER",
            "ID_CAP_BACKUPROAMRESTORE",
            "ID_CAP_BASEOS_UPDATEAPI",
            "ID_CAP_BINGCLIENT_BINGCONFIGURATION",
            "ID_CAP_BINGCLIENT_CA_INTERESTEXTRACTION",
            "ID_CAP_BINGCLIENT_DDC",
            "ID_CAP_BINGCLIENT_IDENTITY",
            "ID_CAP_BINGCLIENT_OSS",
            "ID_CAP_BINGCLIENT_SUGGESTSHIGHLIGHTS",
            "ID_CAP_BINGCLIENT_TEE",
            "ID_CAP_BLUETOOTH",
            "ID_CAP_BLUETOOTH_ADMIN",
            "ID_CAP_BMR2_MONITOR_SERVICE",
            "ID_CAP_BMR_CONFIGURATION",
            "ID_CAP_BMR_SYNC",
            "ID_CAP_BROKER_NAVIGATION",
            "ID_CAP_BROWSER_ACCESSIBILITY_SETTINGS",
            "ID_CAP_BROWSER_FEATURE_CONTROL_KEYS",
            "ID_CAP_BSS_AIM_INTERFACE",
            "ID_CAP_BSS_NABSYNC_INTERFACE",
            "ID_CAP_BSS_PUSH_INTERFACE",
            "ID_CAP_BSS_REMINDER_INTERFACE",
            "ID_CAP_BUILTIN_BASEPRIORITY",
            "ID_CAP_BUILTIN_CREATEGLOBAL",
            "ID_CAP_BUILTIN_CREATEPERMANENT",
            "ID_CAP_BUILTIN_DEFAULT",
            "ID_CAP_BUILTIN_IMPERSONATE",
            "ID_CAP_BUILTIN_PROFILE",
            "ID_CAP_BUILTIN_SETTIME",
            "ID_CAP_BUILTIN_SHUTDOWN",
            "ID_CAP_BUILTIN_SYMBOLICLINK",
            "ID_CAP_BUILTIN_TCB",
            "ID_CAP_BUTTONS",
            "ID_CAP_CALLMESSAGING_FILTER",
            "ID_CAP_CAMERA",
            "ID_CAP_CA_ACTIONURI_TEST_EVENT",
            "ID_CAP_CA_ADMIN",
            "ID_CAP_CA_BACKGROUND_PROCESSOR",
            "ID_CAP_CA_BACKGROUND_PROCESSOR_ADMIN",
            "ID_CAP_CA_CONTEXT",
            "ID_CAP_CA_DND_MANAGER",
            "ID_CAP_CA_ENABLED",
            "ID_CAP_CA_HISTORY",
            "ID_CAP_CA_RULES",
            "ID_CAP_CA_SIGNALS_GENERIC",
            "ID_CAP_CA_SIGNALS_MANAGER",
            "ID_CAP_CA_SIGNALS_MANAGER_ADMIN",
            "ID_CAP_CA_UPLOAD_FOLDER",
            "ID_CAP_CELLUX_CONFIG_READ",
            "ID_CAP_CELL_API_ADMIN",
            "ID_CAP_CELL_API_COMMON",
            "ID_CAP_CELL_API_LOCATION",
            "ID_CAP_CELL_API_MESSAGING",
            "ID_CAP_CELL_API_MODEMLOGGING",
            "ID_CAP_CELL_API_OEM_PASSTHROUGH",
            "ID_CAP_CELL_API_TELEPHONY",
            "ID_CAP_CELL_API_UICC",
            "ID_CAP_CELL_API_UICC_LOWLEVEL",
            "ID_CAP_CELL_CELLMGR",
            "ID_CAP_CELL_CMCSPWWAN_PLUS",
            "ID_CAP_CELL_MSFT_UICC_DATASTORE",
            "ID_CAP_CELL_OEM_UICC_DATASTORE",
            "ID_CAP_CELL_RCSPRESENCE",
            "ID_CAP_CELL_VIDEOTELEPHONY",
            "ID_CAP_CELL_WNF",
            "ID_CAP_CELL_WNF_ADMIN",
            "ID_CAP_CELL_WNF_PII",
            "ID_CAP_CHAMBER_PROFILE_CODE_INSTALLTEMP_RWD",
            "ID_CAP_CHAMBER_PROFILE_CODE_NITEMP_RW",
            "ID_CAP_CHAMBER_PROFILE_CODE_R",
            "ID_CAP_CHAMBER_PROFILE_CODE_RW",
            "ID_CAP_CHAMBER_PROFILE_DATA_LIVETILES_RWD",
            "ID_CAP_CHAMBER_PROFILE_DATA_MEDIA_RWD",
            "ID_CAP_CHAMBER_PROFILE_DATA_PLATFORMDATA_ALL",
            "ID_CAP_CHAMBER_PROFILE_DATA_R",
            "ID_CAP_CHAMBER_PROFILE_DATA_RW",
            "ID_CAP_CHAMBER_PROFILE_DATA_SHELLCONTENT_R",
            "ID_CAP_CHAMBER_PROFILE_DATA_SHELLCONTENT_RWD",
            "ID_CAP_CLIPBOARD",
            "ID_CAP_COMMANDCHANNEL",
            "ID_CAP_COMMS_APPLICATIONS",
            "ID_CAP_COMMS_COMMON",
            "ID_CAP_COMMS_SERVICES",
            "ID_CAP_COMMS_SETTINGS",
            "ID_CAP_CONTACTS",
            "ID_CAP_CONTENTSHARING",
            "ID_CAP_CORTANA_RULES_DB",
            "ID_CAP_CREATE_PROCESS_IN_CHAMBER",
            "ID_CAP_CREDENTIAL_COLLECTION_UI",
            "ID_CAP_CRITICAL_DATA",
            "ID_CAP_CSP_BMR_PROVISION",
            "ID_CAP_CSP_DMCLIENT",
            "ID_CAP_CSP_FOUNDATION",
            "ID_CAP_CSP_LOCATION",
            "ID_CAP_CSP_MAIL",
            "ID_CAP_CSP_NODECACHE",
            "ID_CAP_CSP_OEM",
            "ID_CAP_CSP_PHONE",
            "ID_CAP_CSP_W4_APPLICATION",
            "ID_CAP_CSP_WIFI_HOTSPOT",
            "ID_CAP_DATACOLLECTION_ACTIVITY",
            "ID_CAP_DATACOLLECTION_COLLECTOR",
            "ID_CAP_DATACOLLECTION_RAWETW",
            "ID_CAP_DATAPLANUSAGE",
            "ID_CAP_DATAPLANUSAGE_ADMIN",
            "ID_CAP_DCP",
            "ID_CAP_DEBUG",
            "ID_CAP_DEBUG_FOLDERS",
            "ID_CAP_DEBUG_NAVIGATION",
            "ID_CAP_DEVELOPERUNLOCK",
            "ID_CAP_DEVELOPERUNLOCK_API",
            "ID_CAP_DEVELOPERUNLOCK_CODEDUI",
            "ID_CAP_DEVICE_LOCK",
            "ID_CAP_DEVICE_LOCK_ADMIN",
            "ID_CAP_DEVICE_MANAGEMENT",
            "ID_CAP_DEVICE_MANAGEMENT_ADMIN",
            "ID_CAP_DEVICE_MANAGEMENT_BOOTSTRAP",
            "ID_CAP_DEVICE_MANAGEMENT_SECURITY_POLICIES",
            "ID_CAP_DIAGNOSTIC_CLIENT",
            "ID_CAP_DISPLAY_CONTROL",
            "ID_CAP_DMCLIENT_APPMGMT",
            "ID_CAP_DO_NOT_DISTURB",
            "ID_CAP_DRIVE_MODE_ADMIN",
            "ID_CAP_DUASVC",
            "ID_CAP_DU_AGENT",
            "ID_CAP_DU_CORE_API",
            "ID_CAP_DU_CSP",
            "ID_CAP_DU_MIGRATION_MANAGER_STATUS",
            "ID_CAP_DU_MIGRATION_WNF_EVENTS",
            "ID_CAP_DU_MIGRATOR_PROVISIONING_STATUS_MICROSOFT",
            "ID_CAP_DU_MIGRATOR_PROVISIONING_STATUS_OEM",
            "ID_CAP_DU_MIGRATOR_STATUS_MICROSOFT",
            "ID_CAP_DU_MIGRATOR_STATUS_OEM",
            "ID_CAP_DU_PROVISIONING",
            "ID_CAP_DU_SHARED_DATA",
            "ID_CAP_DU_USS",
            "ID_CAP_DU_UX",
            "ID_CAP_DU_UX_FEATURE_DISCOVERY",
            "ID_CAP_EAS_CREDENTIALS",
            "ID_CAP_EDM_CACHE_RWDELETE",
            "ID_CAP_EDM_CACHE_WRITE",
            "ID_CAP_ENDPOINTDISCOVERY",
            "ID_CAP_ENROLLMENT",
            "ID_CAP_ENROLLMENT_ADMIN",
            "ID_CAP_ENROLLMENT_POLL",
            "ID_CAP_ENROLLMENT_RENEW",
            "ID_CAP_ENTERPRISERESOURCESTORE",
            "ID_CAP_ENTERPRISE_AUTHENTICATION",
            "ID_CAP_ENTERPRISE_ENROLLMENT",
            "ID_CAP_ENTERPRISE_SERVICE",
            "ID_CAP_ENTERPRISE_SHARED_DATA",
            "ID_CAP_ETW_PROFILER",
            "ID_CAP_EVERYONE",
            "ID_CAP_EVERYONE_INROM",
            "ID_CAP_EXTERNAL_DISPLAY",
            "ID_CAP_FAILURE_REPORT_CONTENT_PROVIDER",
            "ID_CAP_FINDMYPHONE",
            "ID_CAP_FOREGROUND_TASK_MANAGER",
            "ID_CAP_GAMERSERVICES",
            "ID_CAP_GLOBALIZATION_SETTINGS",
            "ID_CAP_HTTP_ACCEPT_LANGUAGE_HEADER",
            "ID_CAP_ICS_RO",
            "ID_CAP_ICS_RW",
            "ID_CAP_IDENTITY_DEVICE",
            "ID_CAP_IDENTITY_DEVICE_1ST_PARTY",
            "ID_CAP_IDENTITY_USER",
            "ID_CAP_IDENTITY_USER_1ST_PARTY",
            "ID_CAP_IDM_IMAGE_CACHE",
            "ID_CAP_IMMERSIVE_SHELL",
            "ID_CAP_INPUT_CORE",
            "ID_CAP_INPUT_FEATURES",
            "ID_CAP_INPUT_INJECTION",
            "ID_CAP_INPUT_LOCALES",
            "ID_CAP_INPUT_SERVICE",
            "ID_CAP_INSTALL_CERTIFICATES",
            "ID_CAP_INTENTTEXTRACTION_OPTIN",
            "ID_CAP_INTERNAL_DEPLOYMENT",
            "ID_CAP_INTERNET_EXPLORER_BROWSER_HISTORY",
            "ID_CAP_INTERNET_EXPLORER_DATA_OPTIMIZATION",
            "ID_CAP_INTERNET_EXPLORER_FAVORITES",
            "ID_CAP_INTERNET_EXPLORER_HKCU_WRITE",
            "ID_CAP_INTERNET_EXPLORER_HKLM_SECURITY_SETTINGS",
            "ID_CAP_INTERNET_EXPLORER_INTRANET_ZONE_SETTINGS",
            "ID_CAP_INTERNET_EXPLORER_REMOTEDEBUGGING",
            "ID_CAP_INTERNET_EXPLORER_ROAMING",
            "ID_CAP_INTERNET_EXPLORER_SEARCH_PROVIDER_KEYS_HKCU",
            "ID_CAP_INTEROPSERVICES",
            "ID_CAP_ISV_CAMERA",
            "ID_CAP_KEYBOARD",
            "ID_CAP_KIDZONE_ADMIN",
            "ID_CAP_KIDZONE_CUSTOMIZATION",
            "ID_CAP_LANGUAGEUNDERSTANDING",
            "ID_CAP_LASS_ADMIN",
            "ID_CAP_LASS_REMOTELOCK",
            "ID_CAP_LEGACY_VOICEMAIL_HANDLER",
            "ID_CAP_LEXICONUPDATE",
            "ID_CAP_LIVEID",
            "ID_CAP_LIVETOKEN_WNF_EVENTS",
            "ID_CAP_LOCATION",
            "ID_CAP_LOCATION_ADMIN",
            "ID_CAP_LOCATION_BTPOLICY",
            "ID_CAP_LOCATION_GNSSDRIVER",
            "ID_CAP_MAP",
            "ID_CAP_MAP_ADMIN",
            "ID_CAP_MAP_WRITE",
            "ID_CAP_MEDIALIB",
            "ID_CAP_MEDIALIB_AUDIO",
            "ID_CAP_MEDIALIB_INT",
            "ID_CAP_MEDIALIB_PHOTO",
            "ID_CAP_MEDIALIB_PHOTO_FULL",
            "ID_CAP_MEDIALIB_PLAYBACK",
            "ID_CAP_MEDIALIB_VIDEO",
            "ID_CAP_MEDIASERVICE_VOLUMELIMIT_INT",
            "ID_CAP_MICMUTEPOLICY_BYPASS",
            "ID_CAP_MICROPHONE",
            "ID_CAP_MONITOR_NAVIGATION",
            "ID_CAP_MOUSE",
            "ID_CAP_MO_CLOUDMESSAGING",
            "ID_CAP_MSS_BYTESTREAM_RPC",
            "ID_CAP_MULTIMEDIA_ENCODER_HARDWARE",
            "ID_CAP_MULTIVARIANT",
            "ID_CAP_MULTIVARIANT_INSTALL_DATA",
            "ID_CAP_NARRATOR_SETTINGS",
            "ID_CAP_NATIVE_NETWORK_REPLACEMENT",
            "ID_CAP_NAVIGATIONBAR_ADMIN",
            "ID_CAP_NETWORKING",
            "ID_CAP_NETWORKING_ADMIN",
            "ID_CAP_NETWORKING_INTERNET_CLIENT",
            "ID_CAP_NETWORKING_INTERNET_CLIENT_SERVER",
            "ID_CAP_NETWORKING_PRIVATE_NETWORK_CLIENT_SERVER",
            "ID_CAP_NETWORKING_VPN_ADMIN",
            "ID_CAP_NETWORKING_VPN_PROVIDER",
            "ID_CAP_NETWORKING_VPN_SERVICES",
            "ID_CAP_NFC_ADMIN",
            "ID_CAP_NOCENTER_SOUNDS",
            "ID_CAP_NTSERVICES",
            "ID_CAP_NVREAD",
            "ID_CAP_NVREADWRITE",
            "ID_CAP_O365_DISCOVERY",
            "ID_CAP_OEMPUBLICDIRECTORY",
            "ID_CAP_OEM_ADC",
            "ID_CAP_OEM_CUSTOM",
            "ID_CAP_OEM_DEPLOYMENT",
            "ID_CAP_OFFICE_LAUNCH_URL",
            "ID_CAP_OFFICE_MSDRM_HKCU",
            "ID_CAP_ONENOTE_EVENTS",
            "ID_CAP_OOBE_PRIVATE",
            "ID_CAP_ORIENTATION_LOCK",
            "ID_CAP_PEOPLE_EXTENSION",
            "ID_CAP_PEOPLE_EXTENSION_IM",
            "ID_CAP_PEOPLE_EXTENSION_MOBILE",
            "ID_CAP_PERSONA",
            "ID_CAP_PERSONAL_INFORMATION_IMPORT",
            "ID_CAP_PHONEBROKER_INTERFACE",
            "ID_CAP_PHONEDIALER",
            "ID_CAP_PHONEPROVISIONER_DEVICEUPDATE",
            "ID_CAP_PHONEPROVISIONER_EVENTS",
            "ID_CAP_PHONE_2ND_PARTY",
            "ID_CAP_PHONE_ADMIN",
            "ID_CAP_PHONE_INTERNAL",
            "ID_CAP_PHOTOS_SETTINGS_R",
            "ID_CAP_PHOTOS_SETTINGS_RW",
            "ID_CAP_PICKER_CONTRACT_UI",
            "ID_CAP_PLATFORM_EXTENSIBILITY",
            "ID_CAP_PLAYREADY",
            "ID_CAP_PLAYREADY_ADMIN",
            "ID_CAP_PM_1ST_PARTY",
            "ID_CAP_PM_BSS",
            "ID_CAP_PM_INSTALL",
            "ID_CAP_POIDATASTORE",
            "ID_CAP_POIDATASTORE_ADMIN",
            "ID_CAP_POLICY_MANAGER",
            "ID_CAP_POLICY_MANAGER_READONLY",
            "ID_CAP_POWERNOTIF_USER",
            "ID_CAP_PRESERVED_DATA",
            "ID_CAP_PRIV_ABOUTCPL",
            "ID_CAP_PRIV_ACCESSIBILITYCPL",
            "ID_CAP_PRIV_ACCESSORIESCPL",
            "ID_CAP_PRIV_ACCESSORYMGRSVC",
            "ID_CAP_PRIV_ACCOUNTPROVSVC",
            "ID_CAP_PRIV_ACTIONURIHOST",
            "ID_CAP_PRIV_ADVERTISINGIDCPL",
            "ID_CAP_PRIV_ALARMS",
            "ID_CAP_PRIV_APHCHECK",
            "ID_CAP_PRIV_APMUX",
            "ID_CAP_PRIV_APPCORNER",
            "ID_CAP_PRIV_APPPREINSTALLER",
            "ID_CAP_PRIV_APPRESOLVERUI",
            "ID_CAP_PRIV_APPSDATAMIGRATOR",
            "ID_CAP_PRIV_APPXEXECUTIONSVC",
            "ID_CAP_PRIV_AUTHHOST_MSA",
            "ID_CAP_PRIV_AUTHHOST_WAB_A",
            "ID_CAP_PRIV_AUTHHOST_WAB_B",
            "ID_CAP_PRIV_AUTHHOST_WAB_C",
            "ID_CAP_PRIV_AUTHHOST_WAB_ENTERPRISE",
            "ID_CAP_PRIV_AUTHHOST_WAB_SSO",
            "ID_CAP_PRIV_AUTHHOST_WAB_SSO_ENTERPRISE",
            "ID_CAP_PRIV_AUTOTIMEUPDATE",
            "ID_CAP_PRIV_BATTERYSAVERCPL",
            "ID_CAP_PRIV_BLUETOOTHPBAPSVC",
            "ID_CAP_PRIV_BMR2MONITORSVC",
            "ID_CAP_PRIV_BMR2SCHEDULETRIGGER",
            "ID_CAP_PRIV_BMRCPL",
            "ID_CAP_PRIV_BMRSCHEDULETRIGGER",
            "ID_CAP_PRIV_BRIGHTNESSCPL",
            "ID_CAP_PRIV_BSSVC",
            "ID_CAP_PRIV_BTAGSERVICE",
            "ID_CAP_PRIV_BTCONNMGR",
            "ID_CAP_PRIV_BTHAVCTPSVC",
            "ID_CAP_PRIV_BTSERV",
            "ID_CAP_PRIV_BTUXCPL",
            "ID_CAP_PRIV_CALC7",
            "ID_CAP_PRIV_CAPTURESVC",
            "ID_CAP_PRIV_CASVCSHARED3",
            "ID_CAP_PRIV_CELLMANAGER",
            "ID_CAP_PRIV_CELLULARDATACOLLECTOR",
            "ID_CAP_PRIV_CELLUX",
            "ID_CAP_PRIV_CERTINSTALLER",
            "ID_CAP_PRIV_CFMSVC",
            "ID_CAP_PRIV_CGSVC",
            "ID_CAP_PRIV_CLOUDSTORAGECPL",
            "ID_CAP_PRIV_CMSERVICE",
            "ID_CAP_PRIV_COMMANDCHANNEL",
            "ID_CAP_PRIV_COMMSAPHOST",
            "ID_CAP_PRIV_COMMSAPPLICATIONS",
            "ID_CAP_PRIV_COMMSCERTINSTSVC",
            "ID_CAP_PRIV_COMMSMESSAGESVC",
            "ID_CAP_PRIV_COMMSMMSTRANSPORT",
            "ID_CAP_PRIV_CONTACTSTOKENSVC",
            "ID_CAP_PRIV_CONTENTSHARESVC",
            "ID_CAP_PRIV_CONTENTSHARINGAPP",
            "ID_CAP_PRIV_COREUIREGISTRAR",
            "ID_CAP_PRIV_DACCERTINSTSVC",
            "ID_CAP_PRIV_DATACOLLECTION",
            "ID_CAP_PRIV_DATASENSESVC",
            "ID_CAP_PRIV_DATASMART",
            "ID_CAP_PRIV_DATETIMECPL",
            "ID_CAP_PRIV_DCPSVC",
            "ID_CAP_PRIV_DEBUGGERMUXNOTIFY",
            "ID_CAP_PRIV_DIAGNOSTICSVC",
            "ID_CAP_PRIV_DMCFGHOST",
            "ID_CAP_PRIV_DMOMACPNETWMO",
            "ID_CAP_PRIV_DMOMACPUSERMO",
            "ID_CAP_PRIV_DMWAPPUSHSVC",
            "ID_CAP_PRIV_DRIVINGMODEMANAGER",
            "ID_CAP_PRIV_DRIVINGMODESETTINGS",
            "ID_CAP_PRIV_DSSVC",
            "ID_CAP_PRIV_DSTOKENCLEAN",
            "ID_CAP_PRIV_DUACALLBACK",
            "ID_CAP_PRIV_DUACLIENT",
            "ID_CAP_PRIV_DUCLEANUPMIGRATOR",
            "ID_CAP_PRIV_DUFEATUREDISCOVERY",
            "ID_CAP_PRIV_DUMIGRATIONMANAGER",
            "ID_CAP_PRIV_DUMIGRATIONPROVISIONERMICROSOFT",
            "ID_CAP_PRIV_DUMIGRATIONPROVISIONEROEM",
            "ID_CAP_PRIV_DUPOSTUPDATEUX",
            "ID_CAP_PRIV_DUSTARTINGMIGRATOR",
            "ID_CAP_PRIV_DUSVC",
            "ID_CAP_PRIV_ENROLLMENTCLIENT",
            "ID_CAP_PRIV_ENTAPPSERVICE",
            "ID_CAP_PRIV_ENTERPRISEINSTALL",
            "ID_CAP_PRIV_ENTERPRISEMGMSVC",
            "ID_CAP_PRIV_ENTERPRISERING",
            "ID_CAP_PRIV_ENTERPRISEVALIDATION",
            "ID_CAP_PRIV_EXECMANSERVICE",
            "ID_CAP_PRIV_FINDMYPHONE",
            "ID_CAP_PRIV_FLYOUTDATAMIGRATOR",
            "ID_CAP_PRIV_GROVELER",
            "ID_CAP_PRIV_GWPCENROLLSVC",
            "ID_CAP_PRIV_HFA",
            "ID_CAP_PRIV_HOTSPOTHOST",
            "ID_CAP_PRIV_HUBTILERESTOREHOST",
            "ID_CAP_PRIV_ICSENTITLEMENTHOST",
            "ID_CAP_PRIV_ICSSVC",
            "ID_CAP_PRIV_INPUTSERVICE",
            "ID_CAP_PRIV_INSTALLERWORKER",
            "ID_CAP_PRIV_INTERNETEXPLORER",
            "ID_CAP_PRIV_IPOVERUSB",
            "ID_CAP_PRIV_KEYBOARDCPL",
            "ID_CAP_PRIV_KIDZONECONFIGURATION",
            "ID_CAP_PRIV_KIDZONECUSTOMIZATION",
            "ID_CAP_PRIV_LASSCREDENTIALEXPIRATIONCHECK",
            "ID_CAP_PRIV_LAUNCHAPPSVC",
            "ID_CAP_PRIV_LEXICONUPDATE",
            "ID_CAP_PRIV_LFSVC",
            "ID_CAP_PRIV_LIVETOKEN",
            "ID_CAP_PRIV_LOCATIONUXCPL",
            "ID_CAP_PRIV_LOCKANDWALLPAPER",
            "ID_CAP_PRIV_MEDIA",
            "ID_CAP_PRIV_MEDIASERVICE",
            "ID_CAP_PRIV_MIRRORCPL",
            "ID_CAP_PRIV_MOBILEUI",
            "ID_CAP_PRIV_MOSHOST",
            "ID_CAP_PRIV_MSATICKETSVC",
            "ID_CAP_PRIV_MSGIMTRANSPORT",
            "ID_CAP_PRIV_MSGSMSTRANSPORT",
            "ID_CAP_PRIV_MTP",
            "ID_CAP_PRIV_MVPROVISIONHOST",
            "ID_CAP_PRIV_MVUX",
            "ID_CAP_PRIV_NABSYNC",
            "ID_CAP_PRIV_NOCENTERSETTINGSCPL",
            "ID_CAP_PRIV_NOTIFICATIONPLATFORMMIGRATOR",
            "ID_CAP_PRIV_NOTIFSVC",
            "ID_CAP_PRIV_OFFICE",
            "ID_CAP_PRIV_OMADMCLIENT_ENTERPRISE",
            "ID_CAP_PRIV_OMADMCLIENT_MOBILE_OPERATOR",
            "ID_CAP_PRIV_OMADMPRC",
            "ID_CAP_PRIV_OOBE",
            "ID_CAP_PRIV_ORIENTSRV",
            "ID_CAP_PRIV_PACMANSERVICE",
            "ID_CAP_PRIV_PHONEAUDIOSRV",
            "ID_CAP_PRIV_PHONEPROVISIONER",
            "ID_CAP_PRIV_PHONEPROVISIONER_OEM",
            "ID_CAP_PRIV_PHONESVCSG",
            "ID_CAP_PRIV_PHOTOS",
            "ID_CAP_PRIV_PHOTOSSVC",
            "ID_CAP_PRIV_PIMIDXMAINT",
            "ID_CAP_PRIV_PLACESSVC",
            "ID_CAP_PRIV_POSTDUAPPMIGRATOR",
            "ID_CAP_PRIV_POWERNOTIF",
            "ID_CAP_PRIV_PROXIMITYSVC",
            "ID_CAP_PRIV_PROXYSVC",
            "ID_CAP_PRIV_REALWORLD-BINGCLIENT",
            "ID_CAP_PRIV_REALWORLD-INTERESTEXTRACTION",
            "ID_CAP_PRIV_REBOOTDEVICE",
            "ID_CAP_PRIV_REGIONCPL",
            "ID_CAP_PRIV_REMEMBER",
            "ID_CAP_PRIV_RETAILDEMO",
            "ID_CAP_PRIV_RETAILDEMOERROR",
            "ID_CAP_PRIV_RETAILDEMOGLOB",
            "ID_CAP_PRIV_RETAILDEMOUI",
            "ID_CAP_PRIV_RILADAPTATION",
            "ID_CAP_PRIV_RINGTONESANDSOUNDS",
            "ID_CAP_PRIV_ROAMINGCPL",
            "ID_CAP_PRIV_ROTATIONLOCKCPL",
            "ID_CAP_PRIV_SAPISVR",
            "ID_CAP_PRIV_SECMIGRATOR",
            "ID_CAP_PRIV_SEMGRSVC",
            "ID_CAP_PRIV_SETTINGS",
            "ID_CAP_PRIV_SHELLDATAMIGRATOR",
            "ID_CAP_PRIV_SIREPSVC",
            "ID_CAP_PRIV_SOFTAPUX",
            "ID_CAP_PRIV_SPEECHCPL",
            "ID_CAP_PRIV_SPEECHUPDATE",
            "ID_CAP_PRIV_START",
            "ID_CAP_PRIV_STORAGESENSE",
            "ID_CAP_PRIV_STORAGESVC",
            "ID_CAP_PRIV_STOREDATAMIGRATOR",
            "ID_CAP_PRIV_TASKSCHEDULERSVC",
            "ID_CAP_PRIV_TELCPL",
            "ID_CAP_PRIV_TELREPSVC",
            "ID_CAP_PRIV_THEMECPL",
            "ID_CAP_PRIV_TILEMIGRATOR",
            "ID_CAP_PRIV_TIMEBROKER",
            "ID_CAP_PRIV_UPDATEMGRSVC",
            "ID_CAP_PRIV_USBCPL",
            "ID_CAP_PRIV_USERDATASERVICE",
            "ID_CAP_PRIV_USSREPORTING",
            "ID_CAP_PRIV_UTKSERVICE",
            "ID_CAP_PRIV_UTKUX",
            "ID_CAP_PRIV_VPNUX",
            "ID_CAP_PRIV_WALLET",
            "ID_CAP_PRIV_WALLETSVC",
            "ID_CAP_PRIV_WEHCSPHELPER",
            "ID_CAP_PRIV_WEHSTART",
            "ID_CAP_PRIV_WIFICONNSVC",
            "ID_CAP_PRIV_WIFICPASSIST",
            "ID_CAP_PRIV_WIFICPBROWSERUX",
            "ID_CAP_PRIV_WIFIUDPTEST",
            "ID_CAP_PRIV_WIFIUXBLUE",
            "ID_CAP_PRIV_WLID2MSA",
            "ID_CAP_PRIV_WPABSVC",
            "ID_CAP_PRIV_WPNARRATOR",
            "ID_CAP_PRIV_WPNCERTINSTSVC",
            "ID_CAP_PRIV_WPTOOLS",
            "ID_CAP_PRIV_WPTPMVSCMGRSVC",
            "ID_CAP_PRIV_WPUITESTTOOLS",
            "ID_CAP_PRIV_ZMEDIAQUEUESVC",
            "ID_CAP_PRIV_ZMF",
            "ID_CAP_PRIV_ZMF_SERVICE",
            "ID_CAP_PROVISIONING_PACKAGE_API_ADMIN",
            "ID_CAP_PROVISIONWPCERTIFICATE",
            "ID_CAP_PROXIMITY",
            "ID_CAP_PUBLIC_FOLDER_FULL",
            "ID_CAP_PUBLISH_ALARM_STATE",
            "ID_CAP_PUBLISH_OOBE_STATE",
            "ID_CAP_PUSHROUTER",
            "ID_CAP_PUSH_NOTIFICATION",
            "ID_CAP_PUSH_SERVER",
            "ID_CAP_QUICK_SETTINGS",
            "ID_CAP_READGWPCERTIFICATE",
            "ID_CAP_REBOOT_FLASHING_MODE",
            "ID_CAP_REMEMBER_ADMIN",
            "ID_CAP_REMEMBER_API",
            "ID_CAP_REMOVABLE_STORAGE",
            "ID_CAP_RESET_PHONE",
            "ID_CAP_RESOURCE_MANAGER",
            "ID_CAP_RETAILDEMO_BACKGROUNDIMAGE",
            "ID_CAP_RETAILDEMO_CLIENT",
            "ID_CAP_RETAILDEMO_GLOB_REGISTRY",
            "ID_CAP_RETAILDEMO_OFFLINECONTENT",
            "ID_CAP_RINGTONE_ADD",
            "ID_CAP_ROAMING_CONFIGURATION",
            "ID_CAP_ROTATION_MANAGER",
            "ID_CAP_RUNTIME_CONFIG",
            "ID_CAP_SCREENCAPTURE",
            "ID_CAP_SCREEN_RECORDER",
            "ID_CAP_SCREEN_RECORDER_BKG",
            "ID_CAP_SEARCHMAPS_SHAREDCONFIG",
            "ID_CAP_SEND_TO_ONENOTE",
            "ID_CAP_SENSORS",
            "ID_CAP_SETDEVICENAME",
            "ID_CAP_SETTINGSYNC",
            "ID_CAP_SETTINGSYNC_CONFIGURATION",
            "ID_CAP_SETTINGS_MANAGEMENT_PROVIDER",
            "ID_CAP_SHARED_OBJECT_DIRECTORY",
            "ID_CAP_SHARED_USER_CERTIFICATES",
            "ID_CAP_SHARE_DELEGATE",
            "ID_CAP_SHELL_DEVICE_LOCK_UI_API",
            "ID_CAP_SHELL_LAUNCH_SESSION",
            "ID_CAP_SHELL_NAVIGATION",
            "ID_CAP_SHELL_NOTIFICATION_CLIENT",
            "ID_CAP_SHELL_OEM_ADMIN",
            "ID_CAP_SHELL_RESET_NAVIGATION",
            "ID_CAP_SHELL_TEST_CLIENT",
            "ID_CAP_SHOW_VOLUME_CONTROL",
            "ID_CAP_SMS",
            "ID_CAP_SMS_COMPANION",
            "ID_CAP_SMS_INTERCEPT_AGENT",
            "ID_CAP_SMS_INTERCEPT_RECIPIENT",
            "ID_CAP_SOUND_CONTROL",
            "ID_CAP_SPEECH_GRAMMARS",
            "ID_CAP_SPEECH_RECOGNITION",
            "ID_CAP_SPEECH_RECOGNITION_SYSTEM",
            "ID_CAP_SPEECH_SETTINGS",
            "ID_CAP_SPEECH_UPDATE",
            "ID_CAP_SPLASH_CONFIG",
            "ID_CAP_STARTMENU_CONFIG",
            "ID_CAP_STORAGE_MANAGEMENT",
            "ID_CAP_SUPPRESS_MSA_CONNECT_ARD",
            "ID_CAP_SYNC_EXTENSION",
            "ID_CAP_SYSTEMTRAY_ADMIN",
            "ID_CAP_SYSTEM_ALLOC_WINDOWID",
            "ID_CAP_SYSTEM_COMPOSITOR",
            "ID_CAP_SYSTEM_COUNTERS",
            "ID_CAP_SYSTEM_REGISTRAR",
            "ID_CAP_SYSTEM_WAITCURSOR",
            "ID_CAP_TELEMETRY_ADMIN",
            "ID_CAP_TELEMETRY_CONFIGURE",
            "ID_CAP_TELEMETRY_STUDY",
            "ID_CAP_TEST_NAVIGATION",
            "ID_CAP_TILERESTOREDATA",
            "ID_CAP_TOUCH",
            "ID_CAP_TOUCH_TEST",
            "ID_CAP_TPM_VSCMANAGER",
            "ID_CAP_TS_SCHEDULES_ALL",
            "ID_CAP_USB",
            "ID_CAP_USER_ACTIVITY",
            "ID_CAP_VIDEOSINK_INTERNAL",
            "ID_CAP_VOICEMAIL",
            "ID_CAP_VOIP",
            "ID_CAP_VOIP_CALL_CONTROLLER",
            "ID_CAP_VSTEST_INSTALL_FOLDER",
            "ID_CAP_W32TIME_API",
            "ID_CAP_WAB_RESOURCES",
            "ID_CAP_WALLET",
            "ID_CAP_WALLET_ADMIN",
            "ID_CAP_WALLET_DEALS",
            "ID_CAP_WALLET_PAYMENTINSTRUMENTS",
            "ID_CAP_WALLET_SECUREELEMENT",
            "ID_CAP_WALLPAPER_ADMIN",
            "ID_CAP_WBOEXT",
            "ID_CAP_WEBBROWSERCOMPONENT",
            "ID_CAP_WEB_CREDENTIALS",
            "ID_CAP_WIFI_ADMIN",
            "ID_CAP_WIFI_BASIC",
            "ID_CAP_WIFI_BROWSER",
            "ID_CAP_WIFI_HOTSPOT_HOST",
            "ID_CAP_WIFI_PROFILE_ADMIN",
            "ID_CAP_WIFI_TILE_MANAGER",
            "ID_CAP_WPN_PLATFORM",
            "ID_CAP_WPN_PLATFORM_REG_KEY",
            "ID_CAP_WPTOOLS_INSTALL_FOLDER",
            "ID_CAP_ZMFSERVICES",
            "ID_CAP_ZTRACE",
            "Microsoft.FirmwareRead_cw5n1h2txyewy",
            "Microsoft.FirmwareWrite_cw5n1h2txyewy",
            "AccessoryManager",
            "ActivateAsUser",
            "Activity",
            "ActivityData",
            "ActivitySystem",
            "AllAppMods",
            "AllJoyn",
            "AllowElevation",
            "AppBroadcast",
            "AppBroadcastServices",
            "AppBroadcastSettings",
            "AppCaptureServices",
            "AppCaptureSettings",
            "AppDiagnostics",
            "AppLicensing",
            "AppManagementSystem",
            "ApplicationDefaults",
            "ApplicationViewActivation",
            "Appointments",
            "AppointmentsSystem",
            "AudioDeviceConfiguration",
            "AutomatedAppLaunch",
            "BackgroundMediaPlayback",
            "BackgroundMediaRecording",
            "BackgroundSpatialPerception",
            "BackgroundVoIP",
            "BiometricSystem",
            "BlockedChatMessages",
            "Bluetooth",
            "Bluetooth.GenericAttributeProfile",
            "Bluetooth.Rfcomm",
            "BluetoothAdapter",
            "BluetoothDeviceSettings",
            "BluetoothSync",
            "BootstrapNetworkConnection",
            "BroadFileSystemAccess",
            "BrowserAppList",
            "BrowserCredentials",
            "CameraProcessingExtension",
            "CapabilityAccessConsentDeviceSettings",
            "CellularData",
            "CellularDeviceControl",
            "CellularDeviceIdentity",
            "CellularMessaging",
            "Chat",
            "ChatSystem",
            "ChildWebContent",
            "ChromeInstallFiles",
            "CloudExperienceHost",
            "CloudStore",
            "CodeGeneration",
            "ComPort",
            "ComponentUiInWebContent",
            "ConfirmAppClose",
            "ConstrainedImpersonation",
            "Contacts",
            "ContactsSystem",
            "ContentDeliveryManagerSettings",
            "ContentRestrictions",
            "CoreShell",
            "CortanaPermissions",
            "CortanaSettings",
            "CortanaSpeechAccessory",
            "CortanaSurface",
            "CuratedTileCollections",
            "CustomInstallActions",
            "DateAndTimeDeviceSettings",
            "DependencyTarget",
            "DeveloperSettings",
            "DevelopmentModeNetwork",
            "DeviceEncryptionManagement",
            "DeviceIdentityManagement",
            "DeviceLockManagement",
            "DeviceManagementAdministrator",
            "DeviceManagementDeviceLockPolicies",
            "DeviceManagementDmAccount",
            "DeviceManagementEmailAccount",
            "DeviceManagementFoundation",
            "DeviceManagementRegistration",
            "DeviceManagementWapSecurityPolicies",
            "DevicePortalProvider",
            "DeviceProvisioningAdministrator",
            "DeviceUnlock",
            "Diagnostics",
            "DisplayDeviceSettings",
            "DocumentsLibrary",
            "DolbyLabs.dolbyDAX3ApiService_rz1tebttyb220",
            "DualSimTiles",
            "Email",
            "EmailSystem",
            "EnterpriseAuthentication",
            "EnterpriseCloudSSO",
            "EnterpriseDataPolicy",
            "EnterpriseDeviceLockdown",
            "EraApplication",
            "ExclusiveResource",
            "ExpandedResources",
            "ExtendedBackgroundTaskTime",
            "ExtendedExecutionBackgroundAudio",
            "ExtendedExecutionCritical",
            "ExtendedExecutionUnconstrained",
            "FeatureStagingInfo",
            "FeedbackLogCollection",
            "FirstSignInSettings",
            "FlashPlayerSupport",
            "Fortemedia.audioSettings_4pejv7q2gmsnr",
            "FullFileSystemAccess",
            "GameBarServices",
            "GameConfigStoreManagement",
            "GameList",
            "GameMonitor",
            "GamingContainerResources",
            "GazeInput",
            "GlobalMediaControl",
            "GraphicsCapture",
            "GraphicsCaptureWithoutBorder",
            "HevcPlayback",
            "HfxSystem",
            "HidTelephony",
            "HolographicCompositor",
            "HolographicCompositorSystem",
            "HumanInterfaceDevice",
            "ImeSystem",
            "InProcessMediaExtension",
            "IndexedContent",
            "InputForegroundObservation",
            "InputInjection",
            "InputInjectionBrokered",
            "InputObservation",
            "InputSettings",
            "InputSuppression",
            "Intel.ThunderboltController_8j3eq9eme6ctt",
            "InternetClient",
            "InternetClientServer",
            "InteropServices",
            "KeyboardDeviceSettings",
            "KinectAudio",
            "KinectExpressions",
            "KinectFace",
            "KinectGamechat",
            "KinectRequired",
            "KinectVideo",
            "KinectVision",
            "LanguageAndRegionDeviceSettings",
            "LanguageSettings",
            "LiveIdService",
            "LocalExperienceCumulativeInternal",
            "LocalExperienceInternal",
            "LocalSystemServices",
            "Location",
            "LocationHistory",
            "LocationSystem",
            "LockScreenCreatives",
            "LowLevel",
            "LowLevelDevices",
            "LpacAppExperience",
            "LpacChromeInstallFiles",
            "LpacClipboard",
            "LpacCom",
            "LpacCryptoServices",
            "LpacEnterprisePolicyChangeNotifications",
            "LpacIME",
            "LpacIdentityServices",
            "LpacInstrumentation",
            "LpacMedia",
            "LpacPackageManagerOperation",
            "LpacPayments",
            "LpacPnPNotifications",
            "LpacPrinting",
            "LpacServicesManagement",
            "LpacSessionManagement",
            "LpacWebPlatform",
            "Microphone",
            "Microsoft.classicAppCompat_8wekyb3d8bbwe",
            "Microsoft.deployFullTrustOnHost_8wekyb3d8bbwe",
            "Microsoft.eSIMManagement_8wekyb3d8bbwe",
            "Microsoft.mixedRealityExperience_8wekyb3d8bbwe",
            "Microsoft.uiAccessStandardUserInstall_8wekyb3d8bbwe",
            "MicrosoftEdgeRemoteDebugging",
            "MixedRealityEnvironmentInternal",
            "MmsTransportSystem",
            "ModifiableApp",
            "MultiplaneOverlay",
            "Muma",
            "MusicLibrary",
            "NetworkConnectionManagerProvisioning",
            "NetworkDataPlanProvisioning",
            "NetworkDataUsageManagement",
            "NetworkDeviceSettings",
            "NetworkDiagnostics",
            "NetworkingVpnProvider",
            "NfcSystem",
            "NotificationsDeviceSettings",
            "Objects3D",
            "OemDeployment",
            "OemPublicDirectory",
            "OfflineMapsManagement",
            "OneProcessVoIP",
            "Optical",
            "PacJsWorker",
            "PackageContents",
            "PackageManagement",
            "PackagePolicySystem",
            "PackageQuery",
            "PackageWriteRedirectionCompatibilityShim",
            "PackagedServices",
            "PerceptionMonitoring",
            "PerceptionSensorsExperimental",
            "PerceptionSystem",
            "PermissiveLearningMode",
            "PersonalizationDeviceSettings",
            "PhoneCall",
            "PhoneCallHistory",
            "PhoneCallHistoryPublic",
            "PhoneCallHistorySystem",
            "PhoneCallSystem",
            "PhoneLineTransportManagement",
            "PicturesLibrary",
            "PointOfService",
            "PowerDeviceSettings",
            "PreemptiveCamera",
            "PreviewHfx",
            "PreviewInkWorkspace",
            "PreviewPenWorkspace",
            "PreviewStore",
            "PreviewUiComposition",
            "PrivateNetworkClientServer",
            "ProjectionDeviceSettings",
            "ProtectedApp",
            "Proximity",
            "Radios",
            "RealtekSemiconductorCorp.hdUSBAudio_dt26b99r8h8gj",
            "RecordedCallsFolder",
            "RegionSettings",
            "RegistryRead",
            "RelatedPackages",
            "RemoteFileAccess",
            "RemotePassportAuthentication",
            "RemoteSystem",
            "RemovableStorage",
            "ResetPhone",
            "RunFullTrust",
            "ScreenDuplication",
            "SearchSettings",
            "SecondaryAuthenticationFactor",
            "SecureAssessment",
            "Sensors.Custom",
            "SerialCommunication",
            "SessionImpersonation",
            "SettingSyncConfiguration",
            "SharedMachineKeysCapability",
            "SharedUserCertificates",
            "ShellDisplayManagement",
            "ShellExperience",
            "ShellExperienceComposer",
            "SlapiQueryLicenseValue",
            "Smbios",
            "Sms",
            "SmsSend",
            "SmsSystem",
            "SmsTransportSystem",
            "SoundResearch.audioSettings_sassr7xhpkj7p",
            "SpatialPerception",
            "StartScreenManagement",
            "StoreAppInstall",
            "StoreAppInstallation",
            "StoreConfiguration",
            "StoreLicenseManagement",
            "StoreOptionalPackageInstallManagement",
            "Synaptics.audioControl_807d65c4rvak2",
            "SystemAllocWindowID",
            "SystemDialog",
            "SystemDialogEmergency",
            "SystemManagement",
            "SystemRegistrar",
            "TargetedContent",
            "TargetedContentSubscription",
            "TeamEditionDeviceCredential",
            "TeamEditionExperience",
            "TeamEditionView",
            "TelemetryData",
            "TerminalPowerManagement",
            "ThumbnailCache",
            "Timezone",
            "UiAccess",
            "UiAutomationSystem",
            "UnvirtualizedResources",
            "UnzipFile",
            "UpdateAndSecurityDeviceSettings",
            "Usb",
            "UserAccountInformation",
            "UserDataAccountSetup",
            "UserDataAccountsProvider",
            "UserDataSystem",
            "UserDataTasks",
            "UserDataTasksSystem",
            "UserManagementSystem",
            "UserNotificationListener",
            "UserOnboardingState",
            "UserPrincipalName",
            "UserSigninSupport",
            "UserSystemId",
            "UserWebAccounts",
            "VideosLibrary",
            "VisualElementsSystem",
            "VisualVoiceMail",
            "VoipCall",
            "WmWorkerProcess",
            "WoipCall",
            "WalletSystem",
            "WebPlatformMediaExtension",
            "Webcam",
            "WiFiControl",
            "WiFiDirect",
            "WifiData",
            "WindowManagement",
            "WindowManagementSystem",
            "WindowsHelloCredentialAccess",
            "WindowsPerformanceCounters",
            "XboxAccessoryManagement",
            "XboxBroadcaster",
            "XboxGameSpeechWindow",
            "XboxLiveAuthenticationProvider",
            "XboxSystemApplicationClipQuery",
            "XboxTrackingStream",
            "Xperi.dtsAudioSettings_t5j2fzbtdg37r",
        };
    }
}
