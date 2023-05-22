using System;
using System.Collections.Generic;
using System.Text;

namespace PlayFab
{
    /// <summary>
    /// Error codes returned by PlayFabAPIs
    /// </summary>
    public enum PlayFabErrorCode
    {
        Unknown = 1,
        ConnectionError = 2,
        JsonParseError = 3,
        Success = 0,
        UnkownError = 500,
        InvalidParams = 1000,
        AccountNotFound = 1001,
        AccountBanned = 1002,
        InvalidUsernameOrPassword = 1003,
        InvalidTitleId = 1004,
        InvalidEmailAddress = 1005,
        EmailAddressNotAvailable = 1006,
        InvalidUsername = 1007,
        InvalidPassword = 1008,
        UsernameNotAvailable = 1009,
        InvalidSteamTicket = 1010,
        AccountAlreadyLinked = 1011,
        LinkedAccountAlreadyClaimed = 1012,
        InvalidFacebookToken = 1013,
        AccountNotLinked = 1014,
        FailedByPaymentProvider = 1015,
        CouponCodeNotFound = 1016,
        InvalidContainerItem = 1017,
        ContainerNotOwned = 1018,
        KeyNotOwned = 1019,
        InvalidItemIdInTable = 1020,
        InvalidReceipt = 1021,
        ReceiptAlreadyUsed = 1022,
        ReceiptCancelled = 1023,
        GameNotFound = 1024,
        GameModeNotFound = 1025,
        InvalidGoogleToken = 1026,
        UserIsNotPartOfDeveloper = 1027,
        InvalidTitleForDeveloper = 1028,
        TitleNameConflicts = 1029,
        UserisNotValid = 1030,
        ValueAlreadyExists = 1031,
        BuildNotFound = 1032,
        PlayerNotInGame = 1033,
        InvalidTicket = 1034,
        InvalidDeveloper = 1035,
        InvalidOrderInfo = 1036,
        RegistrationIncomplete = 1037,
        InvalidPlatform = 1038,
        UnknownError = 1039,
        SteamApplicationNotOwned = 1040,
        WrongSteamAccount = 1041,
        TitleNotActivated = 1042,
        RegistrationSessionNotFound = 1043,
        NoSuchMod = 1044,
        FileNotFound = 1045,
        DuplicateEmail = 1046,
        ItemNotFound = 1047,
        ItemNotOwned = 1048,
        ItemNotRecycleable = 1049,
        ItemNotAffordable = 1050,
        InvalidVirtualCurrency = 1051,
        WrongVirtualCurrency = 1052,
        WrongPrice = 1053,
        NonPositiveValue = 1054,
        InvalidRegion = 1055,
        RegionAtCapacity = 1056,
        ServerFailedToStart = 1057,
        NameNotAvailable = 1058,
        InsufficientFunds = 1059,
        InvalidDeviceID = 1060,
        InvalidPushNotificationToken = 1061,
        NoRemainingUses = 1062,
        InvalidPaymentProvider = 1063,
        PurchaseInitializationFailure = 1064,
        DuplicateUsername = 1065,
        InvalidBuyerInfo = 1066,
        NoGameModeParamsSet = 1067,
        BodyTooLarge = 1068,
        ReservedWordInBody = 1069,
        InvalidTypeInBody = 1070,
        InvalidRequest = 1071,
        ReservedEventName = 1072,
        InvalidUserStatistics = 1073,
        NotAuthenticated = 1074,
        StreamAlreadyExists = 1075,
        ErrorCreatingStream = 1076,
        StreamNotFound = 1077,
        InvalidAccount = 1078,
        PurchaseDoesNotExist = 1080,
        InvalidPurchaseTransactionStatus = 1081,
        APINotEnabledForGameClientAccess = 1082,
        NoPushNotificationARNForTitle = 1083,
        BuildAlreadyExists = 1084,
        BuildPackageDoesNotExist = 1085,
        CustomAnalyticsEventsNotEnabledForTitle = 1087,
        InvalidSharedGroupId = 1088,
        NotAuthorized = 1089,
        MissingTitleGoogleProperties = 1090,
        InvalidItemProperties = 1091,
        InvalidPSNAuthCode = 1092,
        InvalidItemId = 1093,
        PushNotEnabledForAccount = 1094,
        PushServiceError = 1095,
        ReceiptDoesNotContainInAppItems = 1096,
        ReceiptContainsMultipleInAppItems = 1097,
        InvalidBundleID = 1098,
        JavascriptException = 1099,
        InvalidSessionTicket = 1100,
        UnableToConnectToDatabase = 1101,
        InternalServerError = 1110,
        InvalidReportDate = 1111,
        ReportNotAvailable = 1112,
        DatabaseThroughputExceeded = 1113,
        InvalidGameTicket = 1115,
        ExpiredGameTicket = 1116,
        GameTicketDoesNotMatchLobby = 1117,
        LinkedDeviceAlreadyClaimed = 1118,
        DeviceAlreadyLinked = 1119,
        DeviceNotLinked = 1120,
        PartialFailure = 1121,
        PublisherNotSet = 1122,
        ServiceUnavailable = 1123,
        VersionNotFound = 1124,
        RevisionNotFound = 1125,
        InvalidPublisherId = 1126,
        DownstreamServiceUnavailable = 1127,
        APINotIncludedInTitleUsageTier = 1128,
        DAULimitExceeded = 1129,
        APIRequestLimitExceeded = 1130,
        InvalidAPIEndpoint = 1131,
        BuildNotAvailable = 1132,
        ConcurrentEditError = 1133,
        ContentNotFound = 1134,
        CharacterNotFound = 1135,
        CloudScriptNotFound = 1136,
        ContentQuotaExceeded = 1137,
        InvalidCharacterStatistics = 1138,
        PhotonNotEnabledForTitle = 1139,
        PhotonApplicationNotFound = 1140,
        PhotonApplicationNotAssociatedWithTitle = 1141,
        InvalidEmailOrPassword = 1142,
        FacebookAPIError = 1143,
        InvalidContentType = 1144,
        KeyLengthExceeded = 1145,
        DataLengthExceeded = 1146,
        TooManyKeys = 1147,
        FreeTierCannotHaveVirtualCurrency = 1148,
        MissingAmazonSharedKey = 1149,
        AmazonValidationError = 1150,
        InvalidPSNIssuerId = 1151,
        PSNInaccessible = 1152,
        ExpiredAuthToken = 1153,
        FailedToGetEntitlements = 1154,
        FailedToConsumeEntitlement = 1155,
        TradeAcceptingUserNotAllowed = 1156,
        TradeInventoryItemIsAssignedToCharacter = 1157,
        TradeInventoryItemIsBundle = 1158,
        TradeStatusNotValidForCancelling = 1159,
        TradeStatusNotValidForAccepting = 1160,
        TradeDoesNotExist = 1161,
        TradeCancelled = 1162,
        TradeAlreadyFilled = 1163,
        TradeWaitForStatusTimeout = 1164,
        TradeInventoryItemExpired = 1165,
        TradeMissingOfferedAndAcceptedItems = 1166,
        TradeAcceptedItemIsBundle = 1167,
        TradeAcceptedItemIsStackable = 1168,
        TradeInventoryItemInvalidStatus = 1169,
        TradeAcceptedCatalogItemInvalid = 1170,
        TradeAllowedUsersInvalid = 1171,
        TradeInventoryItemDoesNotExist = 1172,
        TradeInventoryItemIsConsumed = 1173,
        TradeInventoryItemIsStackable = 1174,
        TradeAcceptedItemsMismatch = 1175,
        InvalidKongregateToken = 1176,
        FeatureNotConfiguredForTitle = 1177,
        NoMatchingCatalogItemForReceipt = 1178,
        InvalidCurrencyCode = 1179,
        NoRealMoneyPriceForCatalogItem = 1180,
        TradeInventoryItemIsNotTradable = 1181,
        TradeAcceptedCatalogItemIsNotTradable = 1182,
        UsersAlreadyFriends = 1183,
        LinkedIdentifierAlreadyClaimed = 1184,
        CustomIdNotLinked = 1185,
        TotalDataSizeExceeded = 1186,
        DeleteKeyConflict = 1187,
        InvalidXboxLiveToken = 1188,
        ExpiredXboxLiveToken = 1189,
        ResettableStatisticVersionRequired = 1190,
        NotAuthorizedByTitle = 1191,
        NoPartnerEnabled = 1192,
        InvalidPartnerResponse = 1193,
        APINotEnabledForGameServerAccess = 1194,
        StatisticNotFound = 1195,
        StatisticNameConflict = 1196,
        StatisticVersionClosedForWrites = 1197,
        StatisticVersionInvalid = 1198,
        APIClientRequestRateLimitExceeded = 1199,
        InvalidJSONContent = 1200,
        InvalidDropTable = 1201,
        StatisticVersionAlreadyIncrementedForScheduledInterval = 1202,
        StatisticCountLimitExceeded = 1203,
        StatisticVersionIncrementRateExceeded = 1204,
        ContainerKeyInvalid = 1205,
        CloudScriptExecutionTimeLimitExceeded = 1206,
        NoWritePermissionsForEvent = 1207,
        CloudScriptFunctionArgumentSizeExceeded = 1208,
        CloudScriptAPIRequestCountExceeded = 1209,
        CloudScriptAPIRequestError = 1210,
        CloudScriptHTTPRequestError = 1211,
        InsufficientGuildRole = 1212,
        GuildNotFound = 1213,
        OverLimit = 1214,
        EventNotFound = 1215,
        InvalidEventField = 1216,
        InvalidEventName = 1217,
        CatalogNotConfigured = 1218,
        OperationNotSupportedForPlatform = 1219,
        SegmentNotFound = 1220,
        StoreNotFound = 1221,
        InvalidStatisticName = 1222,
        TitleNotQualifiedForLimit = 1223,
        InvalidServiceLimitLevel = 1224,
        ServiceLimitLevelInTransition = 1225,
        CouponAlreadyRedeemed = 1226,
        GameServerBuildSizeLimitExceeded = 1227,
        GameServerBuildCountLimitExceeded = 1228,
        VirtualCurrencyCountLimitExceeded = 1229,
        VirtualCurrencyCodeExists = 1230,
        TitleNewsItemCountLimitExceeded = 1231,
        InvalidTwitchToken = 1232,
        TwitchResponseError = 1233,
        ProfaneDisplayName = 1234,
        UserAlreadyAdded = 1235,
        InvalidVirtualCurrencyCode = 1236,
        VirtualCurrencyCannotBeDeleted = 1237,
        IdentifierAlreadyClaimed = 1238,
        IdentifierNotLinked = 1239,
        InvalidContinuationToken = 1240,
        ExpiredContinuationToken = 1241,
        InvalidSegment = 1242,
        InvalidSessionId = 1243,
        SessionLogNotFound = 1244,
        InvalidSearchTerm = 1245,
        TwoFactorAuthenticationTokenRequired = 1246,
        GameServerHostCountLimitExceeded = 1247,
        PlayerTagCountLimitExceeded = 1248,
        RequestAlreadyRunning = 1249,
        ActionGroupNotFound = 1250,
        MaximumSegmentBulkActionJobsRunning = 1251,
        NoActionsOnPlayersInSegmentJob = 1252,
        DuplicateStatisticName = 1253,
        ScheduledTaskNameConflict = 1254,
        ScheduledTaskCreateConflict = 1255,
        InvalidScheduledTaskName = 1256,
        InvalidTaskSchedule = 1257,
        SteamNotEnabledForTitle = 1258,
        LimitNotAnUpgradeOption = 1259,
        NoSecretKeyEnabledForCloudScript = 1260,
        TaskNotFound = 1261,
        TaskInstanceNotFound = 1262,
        InvalidIdentityProviderId = 1263,
        MisconfiguredIdentityProvider = 1264,
        InvalidScheduledTaskType = 1265,
        BillingInformationRequired = 1266,
        LimitedEditionItemUnavailable = 1267,
        InvalidAdPlacementAndReward = 1268,
        AllAdPlacementViewsAlreadyConsumed = 1269,
        GoogleOAuthNotConfiguredForTitle = 1270,
        GoogleOAuthError = 1271,
        UserNotFriend = 1272,
        InvalidSignature = 1273,
        InvalidPublicKey = 1274,
        GoogleOAuthNoIdTokenIncludedInResponse = 1275,
        StatisticUpdateInProgress = 1276,
        LeaderboardVersionNotAvailable = 1277,
        StatisticAlreadyHasPrizeTable = 1279,
        PrizeTableHasOverlappingRanks = 1280,
        PrizeTableHasMissingRanks = 1281,
        PrizeTableRankStartsAtZero = 1282,
        InvalidStatistic = 1283,
        ExpressionParseFailure = 1284,
        ExpressionInvokeFailure = 1285,
        ExpressionTooLong = 1286,
        DataUpdateRateExceeded = 1287,
        RestrictedEmailDomain = 1288,
        EncryptionKeyDisabled = 1289,
        EncryptionKeyMissing = 1290,
        EncryptionKeyBroken = 1291,
        NoSharedSecretKeyConfigured = 1292,
        SecretKeyNotFound = 1293,
        PlayerSecretAlreadyConfigured = 1294,
        APIRequestsDisabledForTitle = 1295,
        InvalidSharedSecretKey = 1296,
        PrizeTableHasNoRanks = 1297,
        ProfileDoesNotExist = 1298,
        ContentS3OriginBucketNotConfigured = 1299,
        InvalidEnvironmentForReceipt = 1300,
        EncryptedRequestNotAllowed = 1301,
        SignedRequestNotAllowed = 1302,
        RequestViewConstraintParamsNotAllowed = 1303,
        BadPartnerConfiguration = 1304,
        XboxBPCertificateFailure = 1305,
        XboxXASSExchangeFailure = 1306,
        InvalidEntityId = 1307,
        StatisticValueAggregationOverflow = 1308,
        EmailMessageFromAddressIsMissing = 1309,
        EmailMessageToAddressIsMissing = 1310,
        SmtpServerAuthenticationError = 1311,
        SmtpServerLimitExceeded = 1312,
        SmtpServerInsufficientStorage = 1313,
        SmtpServerCommunicationError = 1314,
        SmtpServerGeneralFailure = 1315,
        EmailClientTimeout = 1316,
        EmailClientCanceledTask = 1317,
        EmailTemplateMissing = 1318,
        InvalidHostForTitleId = 1319,
        EmailConfirmationTokenDoesNotExist = 1320,
        EmailConfirmationTokenExpired = 1321,
        AccountDeleted = 1322,
        PlayerSecretNotConfigured = 1323,
        InvalidSignatureTime = 1324,
        NoContactEmailAddressFound = 1325,
        InvalidAuthToken = 1326,
        AuthTokenDoesNotExist = 1327,
        AuthTokenExpired = 1328,
        AuthTokenAlreadyUsedToResetPassword = 1329,
        MembershipNameTooLong = 1330,
        MembershipNotFound = 1331,
        GoogleServiceAccountInvalid = 1332,
        GoogleServiceAccountParseFailure = 1333,
        EntityTokenMissing = 1334,
        EntityTokenInvalid = 1335,
        EntityTokenExpired = 1336,
        EntityTokenRevoked = 1337,
        InvalidProductForSubscription = 1338,
        XboxInaccessible = 1339,
        SubscriptionAlreadyTaken = 1340,
        SmtpAddonNotEnabled = 1341,
        APIConcurrentRequestLimitExceeded = 1342,
        XboxRejectedXSTSExchangeRequest = 1343,
        VariableNotDefined = 1344,
        TemplateVersionNotDefined = 1345,
        FileTooLarge = 1346,
        TitleDeleted = 1347,
        TitleContainsUserAccounts = 1348,
        TitleDeletionPlayerCleanupFailure = 1349,
        EntityFileOperationPending = 1350,
        NoEntityFileOperationPending = 1351,
        EntityProfileVersionMismatch = 1352,
        TemplateVersionTooOld = 1353,
        MembershipDefinitionInUse = 1354,
        PaymentPageNotConfigured = 1355,
        FailedLoginAttemptRateLimitExceeded = 1356,
        EntityBlockedByGroup = 1357,
        RoleDoesNotExist = 1358,
        EntityIsAlreadyMember = 1359,
        DuplicateRoleId = 1360,
        GroupInvitationNotFound = 1361,
        GroupApplicationNotFound = 1362,
        OutstandingInvitationAcceptedInstead = 1363,
        OutstandingApplicationAcceptedInstead = 1364,
        RoleIsGroupDefaultMember = 1365,
        RoleIsGroupAdmin = 1366,
        RoleNameNotAvailable = 1367,
        GroupNameNotAvailable = 1368,
        EmailReportAlreadySent = 1369,
        EmailReportRecipientBlacklisted = 1370,
        EventNamespaceNotAllowed = 1371,
        EventEntityNotAllowed = 1372,
        InvalidEntityType = 1373,
        NullTokenResultFromAad = 1374,
        InvalidTokenResultFromAad = 1375,
        NoValidCertificateForAad = 1376,
        InvalidCertificateForAad = 1377,
        DuplicateDropTableId = 1378,
        MultiplayerServerError = 1379,
        MultiplayerServerTooManyRequests = 1380,
        MultiplayerServerNoContent = 1381,
        MultiplayerServerBadRequest = 1382,
        MultiplayerServerUnauthorized = 1383,
        MultiplayerServerForbidden = 1384,
        MultiplayerServerNotFound = 1385,
        MultiplayerServerConflict = 1386,
        MultiplayerServerInternalServerError = 1387,
        MultiplayerServerUnavailable = 1388,
        ExplicitContentDetected = 1389,
        PIIContentDetected = 1390,
        InvalidScheduledTaskParameter = 1391,
        PerEntityEventRateLimitExceeded = 1392,
        TitleDefaultLanguageNotSet = 1393,
        EmailTemplateMissingDefaultVersion = 1394,
        FacebookInstantGamesIdNotLinked = 1395,
        InvalidFacebookInstantGamesSignature = 1396,
        FacebookInstantGamesAuthNotConfiguredForTitle = 1397,
        EntityProfileConstraintValidationFailed = 1398,
        TelemetryIngestionKeyPending = 1399,
        TelemetryIngestionKeyNotFound = 1400,
        StatisticChildNameInvalid = 1402,
        DataIntegrityError = 1403,
        VirtualCurrencyCannotBeSetToOlderVersion = 1404,
        VirtualCurrencyMustBeWithinIntegerRange = 1405,
        EmailTemplateInvalidSyntax = 1406,
        EmailTemplateMissingCallback = 1407,
        PushNotificationTemplateInvalidPayload = 1408,
        InvalidLocalizedPushNotificationLanguage = 1409,
        MissingLocalizedPushNotificationMessage = 1410,
        PushNotificationTemplateMissingPlatformPayload = 1411,
        PushNotificationTemplatePayloadContainsInvalidJson = 1412,
        PushNotificationTemplateContainsInvalidIosPayload = 1413,
        PushNotificationTemplateContainsInvalidAndroidPayload = 1414,
        PushNotificationTemplateIosPayloadMissingNotificationBody = 1415,
        PushNotificationTemplateAndroidPayloadMissingNotificationBody = 1416,
        PushNotificationTemplateNotFound = 1417,
        PushNotificationTemplateMissingDefaultVersion = 1418,
        PushNotificationTemplateInvalidSyntax = 1419,
        PushNotificationTemplateNoCustomPayloadForV1 = 1420,
        NoLeaderboardForStatistic = 1421,
        TitleNewsMissingDefaultLanguage = 1422,
        TitleNewsNotFound = 1423,
        TitleNewsDuplicateLanguage = 1424,
        TitleNewsMissingTitleOrBody = 1425,
        TitleNewsInvalidLanguage = 1426,
        EmailRecipientBlacklisted = 1427,
        InvalidGameCenterAuthRequest = 1428,
        GameCenterAuthenticationFailed = 1429,
        CannotEnablePartiesForTitle = 1430,
        PartyError = 1431,
        PartyRequests = 1432,
        PartyNoContent = 1433,
        PartyBadRequest = 1434,
        PartyUnauthorized = 1435,
        PartyForbidden = 1436,
        PartyNotFound = 1437,
        PartyConflict = 1438,
        PartyInternalServerError = 1439,
        PartyUnavailable = 1440,
        PartyTooManyRequests = 1441,
        PushNotificationTemplateMissingName = 1442,
        CannotEnableMultiplayerServersForTitle = 1443,
        WriteAttemptedDuringExport = 1444,
        MultiplayerServerTitleQuotaCoresExceeded = 1445,
        AutomationRuleNotFound = 1446,
        EntityAPIKeyLimitExceeded = 1447,
        EntityAPIKeyNotFound = 1448,
        EntityAPIKeyOrSecretInvalid = 1449,
        EconomyServiceUnavailable = 1450,
        EconomyServiceInternalError = 1451,
        QueryRateLimitExceeded = 1452,
        EntityAPIKeyCreationDisabledForEntity = 1453,
        ForbiddenByEntityPolicy = 1454,
        UpdateInventoryRateLimitExceeded = 1455,
        StudioCreationRateLimited = 1456,
        StudioCreationInProgress = 1457,
        DuplicateStudioName = 1458,
        StudioNotFound = 1459,
        StudioDeleted = 1460,
        StudioDeactivated = 1461,
        StudioActivated = 1462,
        TitleCreationRateLimited = 1463,
        TitleCreationInProgress = 1464,
        DuplicateTitleName = 1465,
        TitleActivationRateLimited = 1466,
        TitleActivationInProgress = 1467,
        TitleDeactivated = 1468,
        TitleActivated = 1469,
        CloudScriptAzureFunctionsExecutionTimeLimitExceeded = 1470,
        CloudScriptAzureFunctionsArgumentSizeExceeded = 1471,
        CloudScriptAzureFunctionsReturnSizeExceeded = 1472,
        CloudScriptAzureFunctionsHTTPRequestError = 1473,
        VirtualCurrencyBetaGetError = 1474,
        VirtualCurrencyBetaCreateError = 1475,
        VirtualCurrencyBetaInitialDepositSaveError = 1476,
        VirtualCurrencyBetaSaveError = 1477,
        VirtualCurrencyBetaDeleteError = 1478,
        VirtualCurrencyBetaRestoreError = 1479,
        VirtualCurrencyBetaSaveConflict = 1480,
        VirtualCurrencyBetaUpdateError = 1481,
        InsightsManagementDatabaseNotFound = 1482,
        InsightsManagementOperationNotFound = 1483,
        InsightsManagementErrorPendingOperationExists = 1484,
        InsightsManagementSetPerformanceLevelInvalidParameter = 1485,
        InsightsManagementSetStorageRetentionInvalidParameter = 1486,
        InsightsManagementGetStorageUsageInvalidParameter = 1487,
        InsightsManagementGetOperationStatusInvalidParameter = 1488,
        DuplicatePurchaseTransactionId = 1489,
        EvaluationModePlayerCountExceeded = 1490,
        GetPlayersInSegmentRateLimitExceeded = 1491,
        CloudScriptFunctionNameSizeExceeded = 1492,
        PaidInsightsFeaturesNotEnabled = 1493,
        CloudScriptAzureFunctionsQueueRequestError = 1494,
        EvaluationModeTitleCountExceeded = 1495,
        InsightsManagementTitleNotInFlight = 1496,
        LimitNotFound = 1497,
        LimitNotAvailableViaAPI = 1498,
        InsightsManagementSetStorageRetentionBelowMinimum = 1499,
        InsightsManagementSetStorageRetentionAboveMaximum = 1500,
        AppleNotEnabledForTitle = 1501,
        InsightsManagementNewActiveEventExportLimitInvalid = 1502,
        InsightsManagementSetPerformanceRateLimited = 1503,
        PartyRequestsThrottledFromRateLimiter = 1504,
        XboxServiceTooManyRequests = 1505,
        NintendoSwitchNotEnabledForTitle = 1506,
        RequestMultiplayerServersThrottledFromRateLimiter = 1507,
        TitleDataOverrideNotFound = 1508,
        DuplicateKeys = 1509,
        WasNotCreatedWithCloudRoot = 1510,
        LegacyMultiplayerServersDeprecated = 1511,
        VirtualCurrencyCurrentlyUnavailable = 1512,
        SteamUserNotFound = 1513,
        ElasticSearchOperationFailed = 1514,
        NotImplemented = 1515,
        PublisherNotFound = 1516,
        PublisherDeleted = 1517,
        ApiDisabledForMigration = 1518,
        ResourceNameUpdateNotAllowed = 1519,
        ApiNotEnabledForTitle = 1520,
        DuplicateTitleNameForPublisher = 1521,
        AzureTitleCreationInProgress = 1522,
        TitleConstraintsPublisherDeletion = 1524,
        InvalidPlayerAccountPoolId = 1525,
        PlayerAccountPoolNotFound = 1526,
        PlayerAccountPoolDeleted = 1527,
        TitleCleanupInProgress = 1528,
        AzureResourceConcurrentOperationInProgress = 1529,
        TitlePublisherUpdateNotAllowed = 1530,
        AzureResourceManagerNotSupportedInStamp = 1531,
        ApiNotIncludedInAzurePlayFabFeatureSet = 1532,
        GoogleServiceAccountFailedAuth = 1533,
        GoogleAPIServiceUnavailable = 1534,
        GoogleAPIServiceUnknownError = 1535,
        NoValidIdentityForAad = 1536,
        PlayerIdentityLinkNotFound = 1537,
        PhotonApplicationIdAlreadyInUse = 1538,
        CloudScriptUnableToDeleteProductionRevision = 1539,
        CustomIdNotFound = 1540,
        AutomationInvalidInput = 1541,
        AutomationInvalidRuleName = 1542,
        AutomationRuleAlreadyExists = 1543,
        AutomationRuleLimitExceeded = 1544,
        InvalidGooglePlayGamesServerAuthCode = 1545,
        PlayStreamConnectionFailed = 1547,
        InvalidEventContents = 1548,
        InsightsV1Deprecated = 1549,
        AnalysisSubscriptionNotFound = 1550,
        AnalysisSubscriptionFailed = 1551,
        AnalysisSubscriptionFoundAlready = 1552,
        AnalysisSubscriptionManagementInvalidInput = 1553,
        InvalidGameCenterId = 1554,
        InvalidNintendoSwitchAccountId = 1555,
        EntityAPIKeysNotSupported = 1556,
        IpAddressBanned = 1557,
        EntityLineageBanned = 1558,
        NamespaceMismatch = 1559,
        InvalidServiceConfiguration = 1560,
        InvalidNamespaceMismatch = 1561,
        MatchmakingEntityInvalid = 2001,
        MatchmakingPlayerAttributesInvalid = 2002,
        MatchmakingQueueNotFound = 2016,
        MatchmakingMatchNotFound = 2017,
        MatchmakingTicketNotFound = 2018,
        MatchmakingAlreadyJoinedTicket = 2028,
        MatchmakingTicketAlreadyCompleted = 2029,
        MatchmakingQueueConfigInvalid = 2031,
        MatchmakingMemberProfileInvalid = 2032,
        NintendoSwitchDeviceIdNotLinked = 2034,
        MatchmakingNotEnabled = 2035,
        MatchmakingPlayerAttributesTooLarge = 2043,
        MatchmakingNumberOfPlayersInTicketTooLarge = 2044,
        MatchmakingAttributeInvalid = 2046,
        MatchmakingPlayerHasNotJoinedTicket = 2053,
        MatchmakingRateLimitExceeded = 2054,
        MatchmakingTicketMembershipLimitExceeded = 2055,
        MatchmakingUnauthorized = 2056,
        MatchmakingQueueLimitExceeded = 2057,
        MatchmakingRequestTypeMismatch = 2058,
        MatchmakingBadRequest = 2059,
        PubSubFeatureNotEnabledForTitle = 2500,
        PubSubTooManyRequests = 2501,
        PubSubConnectionNotFoundForEntity = 2502,
        PubSubConnectionHandleInvalid = 2503,
        PubSubSubscriptionLimitExceeded = 2504,
        TitleConfigNotFound = 3001,
        TitleConfigUpdateConflict = 3002,
        TitleConfigSerializationError = 3003,
        CatalogApiNotImplemented = 4000,
        CatalogEntityInvalid = 4001,
        CatalogTitleIdMissing = 4002,
        CatalogPlayerIdMissing = 4003,
        CatalogClientIdentityInvalid = 4004,
        CatalogOneOrMoreFilesInvalid = 4005,
        CatalogItemMetadataInvalid = 4006,
        CatalogItemIdInvalid = 4007,
        CatalogSearchParameterInvalid = 4008,
        CatalogFeatureDisabled = 4009,
        CatalogConfigInvalid = 4010,
        CatalogItemTypeInvalid = 4012,
        CatalogBadRequest = 4013,
        CatalogTooManyRequests = 4014,
        ExportInvalidStatusUpdate = 5000,
        ExportInvalidPrefix = 5001,
        ExportBlobContainerDoesNotExist = 5002,
        ExportNotFound = 5004,
        ExportCouldNotUpdate = 5005,
        ExportInvalidStorageType = 5006,
        ExportAmazonBucketDoesNotExist = 5007,
        ExportInvalidBlobStorage = 5008,
        ExportKustoException = 5009,
        ExportKustoConnectionFailed = 5012,
        ExportUnknownError = 5013,
        ExportCantEditPendingExport = 5014,
        ExportLimitExports = 5015,
        ExportLimitEvents = 5016,
        ExportInvalidPartitionStatusModification = 5017,
        ExportCouldNotCreate = 5018,
        ExportNoBackingDatabaseFound = 5019,
        ExportCouldNotDelete = 5020,
        ExportCannotDetermineEventQuery = 5021,
        ExportInvalidQuerySchemaModification = 5022,
        ExportQuerySchemaMissingRequiredColumns = 5023,
        ExportCannotParseQuery = 5024,
        ExportControlCommandsNotAllowed = 5025,
        ExportQueryMissingTableReference = 5026,
        ExportInsightsV1Deprecated = 5027,
        ExplorerBasicInvalidQueryName = 5100,
        ExplorerBasicInvalidQueryDescription = 5101,
        ExplorerBasicInvalidQueryConditions = 5102,
        ExplorerBasicInvalidQueryStartDate = 5103,
        ExplorerBasicInvalidQueryEndDate = 5104,
        ExplorerBasicInvalidQueryGroupBy = 5105,
        ExplorerBasicInvalidQueryAggregateType = 5106,
        ExplorerBasicInvalidQueryAggregateProperty = 5107,
        ExplorerBasicLoadQueriesError = 5108,
        ExplorerBasicLoadQueryError = 5109,
        ExplorerBasicCreateQueryError = 5110,
        ExplorerBasicDeleteQueryError = 5111,
        ExplorerBasicUpdateQueryError = 5112,
        ExplorerBasicSavedQueriesLimit = 5113,
        ExplorerBasicSavedQueryNotFound = 5114,
        TenantShardMapperShardNotFound = 5500,
        TitleNotEnabledForParty = 6000,
        PartyVersionNotFound = 6001,
        MultiplayerServerBuildReferencedByMatchmakingQueue = 6002,
        MultiplayerServerBuildReferencedByBuildAlias = 6003,
        MultiplayerServerBuildAliasReferencedByMatchmakingQueue = 6004,
        ExperimentationExperimentStopped = 7000,
        ExperimentationExperimentRunning = 7001,
        ExperimentationExperimentNotFound = 7002,
        ExperimentationExperimentNeverStarted = 7003,
        ExperimentationExperimentDeleted = 7004,
        ExperimentationClientTimeout = 7005,
        ExperimentationInvalidVariantConfiguration = 7006,
        ExperimentationInvalidVariableConfiguration = 7007,
        ExperimentInvalidId = 7008,
        ExperimentationNoScorecard = 7009,
        ExperimentationTreatmentAssignmentFailed = 7010,
        ExperimentationTreatmentAssignmentDisabled = 7011,
        ExperimentationInvalidDuration = 7012,
        ExperimentationMaxExperimentsReached = 7013,
        ExperimentationExperimentSchedulingInProgress = 7014,
        ExperimentationInvalidEndDate = 7015,
        ExperimentationInvalidStartDate = 7016,
        ExperimentationMaxDurationExceeded = 7017,
        ExperimentationExclusionGroupNotFound = 7018,
        ExperimentationExclusionGroupInsufficientCapacity = 7019,
        ExperimentationExclusionGroupCannotDelete = 7020,
        ExperimentationExclusionGroupInvalidTrafficAllocation = 7021,
        ExperimentationExclusionGroupInvalidName = 7022,
        MaxActionDepthExceeded = 8000,
        TitleNotOnUpdatedPricingPlan = 9000,
        SegmentManagementTitleNotInFlight = 10000,
        SegmentManagementNoExpressionTree = 10001,
        SegmentManagementTriggerActionCountOverLimit = 10002,
        SegmentManagementSegmentCountOverLimit = 10003,
        SegmentManagementInvalidSegmentId = 10004,
        SegmentManagementInvalidInput = 10005,
        SegmentManagementInvalidSegmentName = 10006,
        DeleteSegmentRateLimitExceeded = 10007,
        CreateSegmentRateLimitExceeded = 10008,
        UpdateSegmentRateLimitExceeded = 10009,
        GetSegmentsRateLimitExceeded = 10010,
        AsyncExportNotInFlight = 10011,
        AsyncExportNotFound = 10012,
        AsyncExportRateLimitExceeded = 10013,
        AnalyticsSegmentCountOverLimit = 10014,
        SnapshotNotFound = 11000,
        InventoryApiNotImplemented = 12000,
        LobbyDoesNotExist = 13000,
        LobbyRateLimitExceeded = 13001,
        LobbyPlayerAlreadyJoined = 13002,
        LobbyNotJoinable = 13003,
        LobbyMemberCannotRejoin = 13004,
        LobbyCurrentPlayersMoreThanMaxPlayers = 13005,
        LobbyPlayerNotPresent = 13006,
        LobbyBadRequest = 13007,
        LobbyPlayerMaxLobbyLimitExceeded = 13008,
        LobbyNewOwnerMustBeConnected = 13009,
        LobbyCurrentOwnerStillConnected = 13010,
        LobbyMemberIsNotOwner = 13011,
        EventSamplingInvalidRatio = 14000,
        EventSamplingInvalidEventNamespace = 14001,
        EventSamplingInvalidEventName = 14002,
        EventSamplingRatioNotFound = 14003,
        TelemetryKeyNotFound = 14200,
        TelemetryKeyInvalidName = 14201,
        TelemetryKeyAlreadyExists = 14202,
        TelemetryKeyInvalid = 14203,
        TelemetryKeyCountOverLimit = 14204,
        TelemetryKeyDeactivated = 14205,
        EventSinkConnectionInvalid = 15000,
        EventSinkConnectionUnauthorized = 15001,
        EventSinkRegionInvalid = 15002,
        EventSinkLimitExceeded = 15003,
        EventSinkSasTokenInvalid = 15004,
        EventSinkNotFound = 15005,
        EventSinkNameInvalid = 15006,
        EventSinkSasTokenPermissionInvalid = 15007,
        EventSinkSecretInvalid = 15008,
        EventSinkTenantNotFound = 15009,
        EventSinkAadNotFound = 15010,
        EventSinkDatabaseNotFound = 15011,
        OperationCanceled = 16000,
        InvalidDisplayNameRandomSuffixLength = 17000,
        AllowNonUniquePlayerDisplayNamesDisableNotAllowed = 17001,
        PartitionedEventInvalid = 18000,
        PartitionedEventCountOverLimit = 18001,
        PlayerCustomPropertiesPropertyNameTooLong = 19000,
        PlayerCustomPropertiesPropertyNameIsInvalid = 19001,
        PlayerCustomPropertiesStringPropertyValueTooLong = 19002,
        PlayerCustomPropertiesValueIsInvalidType = 19003,
        PlayerCustomPropertiesVersionMismatch = 19004,
        PlayerCustomPropertiesPropertyCountTooHigh = 19005,
        PlayerCustomPropertiesDuplicatePropertyName = 19006,
        PlayerCustomPropertiesPropertyDoesNotExist = 19007
    }

    public class PlayFabError
    {
        public string ApiEndpoint;
        public int HttpCode;
        public string HttpStatus;
        public PlayFabErrorCode Error;
        public string ErrorMessage;
        public Dictionary<string, List<string>> ErrorDetails;
        public object CustomData;
        public uint? RetryAfterSeconds = null;

        public override string ToString()
        {
            return GenerateErrorReport();
        }

        [ThreadStatic]
        private static StringBuilder _tempSb;
        /// <summary>
        /// This converts the PlayFabError into a human readable string describing the error.
        /// If error is not found, it will return the http code, status, and error
        /// </summary>
        /// <returns>A description of the error that we just incur.</returns>
        public string GenerateErrorReport()
        {
            if (_tempSb == null)
                _tempSb = new StringBuilder();
            _tempSb.Length = 0;
            if (String.IsNullOrEmpty(ErrorMessage))
            {
                _tempSb.Append(ApiEndpoint).Append(": ").Append("Http Code: ").Append(HttpCode.ToString()).Append("\nHttp Status: ").Append(HttpStatus).Append("\nError: ").Append(Error.ToString()).Append("\n");
            }
            else
            {
                _tempSb.Append(ApiEndpoint).Append(": ").Append(ErrorMessage);
            }

            if (ErrorDetails != null)
                foreach (var pair in ErrorDetails)
                    foreach (var msg in pair.Value)
                        _tempSb.Append("\n").Append(pair.Key).Append(": ").Append(msg);
            return _tempSb.ToString();
        }
    }

    public class PlayFabException : Exception
    {
        public readonly PlayFabExceptionCode Code;
        public PlayFabException(PlayFabExceptionCode code, string message) : base(message)
        {
            Code = code;
        }
    }

    public enum PlayFabExceptionCode
    {
        AuthContextRequired,
        BuildError,
        DeveloperKeyNotSet,
        EntityTokenNotSet,
        NotLoggedIn,
        TitleNotSet,
    }
}
