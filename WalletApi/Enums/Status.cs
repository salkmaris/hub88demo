﻿namespace WalletApi.Enums
{
    public enum Status
    {
        RS_OK, 
        RS_ERROR_UNKNOWN, 
        RS_ERROR_INVALID_PARTNER, 
        RS_ERROR_INVALID_TOKEN, 
        RS_ERROR_INVALID_GAMERS,
        RS_ERROR_WRONG_CURRENCY, 
        RS_ERROR_NOT_ENOUGH_MONEY, 
        RS_ERROR_USER_DISABLED, 
        RS_ERROR_INVALID_SIGNATURE, 
        RS_ERROR_TOKEN_EXPIRED, 
        RS_ERROR_WRONG_SYNTAX, 
        RS_ERROR_WRONG_TYPES, 
        RS_ERROR_DUPLICATE_TRANSACTION, 
        RS_ERROR_TRANSACTION_DOES_NOT_EXIST
    }
}