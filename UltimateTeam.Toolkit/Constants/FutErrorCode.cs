﻿namespace UltimateTeam.Toolkit.Constants
{
    public enum FutErrorCode : ushort
    {
        NoSecurityQuestionSetup = 204,
        ExpiredSession = 401,
        NotFound = 404,
        Conflict = 409,
        UpgradeRequired = 426,
        TooManyRequests = 429,
        CaptchaTriggered = 459,
        BadRequest = 460,
        PermissionDenied = 461,
        NotEnoughCredit = 470,
        PurchasedItemsFull = 471,
        DestinationFull = 473,
        InvalidTransaction = 475,
        InvalidDeck = 477,
        NoSuchTradeExists = 478,
        ServiceDisabled = 480,
        AccountLocked = 481,
        InvalidCookie = 482,
        AlreadyAuthenticated = 483,
        NoRemainingAuthenticationAttemptsAccountLocked = 485,
        TransfermarketBlocked = 494,
        InternalServerError = 500,
        BadGateway = 502,
        ServiceUnavailable = 503,
        Unknown_HTTP_512 = 512,
        Unknown_HTTP_521 = 521,
    }
}
