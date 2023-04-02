﻿namespace CookBook.Shared
{
    internal interface IDialogService
    { 
        Task<bool> DisplayConfirm(string title, string message, string accept, string cancel);
    }
}
