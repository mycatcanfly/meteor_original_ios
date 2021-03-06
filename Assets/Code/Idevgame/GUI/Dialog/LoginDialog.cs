﻿using Idevgame.GameState.DialogState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class LoginDialogState : CommonDialogState<LoginDialog>
{
    public override string DialogName { get { return "LoginDialog"; } }
    public LoginDialogState(MainDialogStateManager stateMgr) : base(stateMgr)
    {

    }
}

public class LoginDialog : Dialog
{
    InputField Account;
    InputField Password;
    UIButtonExtended Login;
    UIButtonExtended Register;
    UIButtonExtended QuickRegister;
    Toggle AutoLogin;
    Toggle RememberPassword;
    public override void OnDialogStateEnter(BaseDialogState ownerState, BaseDialogState previousDialog, object data)
    {
        base.OnDialogStateEnter(ownerState, previousDialog, data);
        Init();
    }

    public void Init()
    {
        Account = Control("Account").GetComponent<InputField>();
        Password = Control("Password").GetComponent<InputField>();
        Login = Control("Confirm").GetComponent<UIButtonExtended>();
        Register = Control("Register").GetComponent<UIButtonExtended>();
        QuickRegister = Control("QuickGame").GetComponent<UIButtonExtended>();

        AutoLogin = Control("AutoLogin").GetComponent<Toggle>();
        RememberPassword = Control("RemPsw").GetComponent<Toggle>();
        if (Main.Instance.GameStateMgr.gameStatus.AutoLogin)
            Main.Instance.GameStateMgr.gameStatus.RememberPassword = true;
        AutoLogin.isOn = Main.Instance.GameStateMgr.gameStatus.AutoLogin;
        RememberPassword.isOn = Main.Instance.GameStateMgr.gameStatus.RememberPassword;

        AutoLogin.onValueChanged.AddListener((bool on) => { Main.Instance.GameStateMgr.gameStatus.AutoLogin = on; });
        RememberPassword.onValueChanged.AddListener((bool on) => { Main.Instance.GameStateMgr.gameStatus.RememberPassword = on; });


        if (!string.IsNullOrEmpty(Main.Instance.GameStateMgr.gameStatus.Account) && Main.Instance.GameStateMgr.gameStatus.AutoLogin)
            Account.text = Main.Instance.GameStateMgr.gameStatus.Account;
        if (!string.IsNullOrEmpty(Main.Instance.GameStateMgr.gameStatus.Password) && Main.Instance.GameStateMgr.gameStatus.RememberPassword)
            Password.text = Main.Instance.GameStateMgr.gameStatus.Password;

        if (Main.Instance.GameStateMgr.gameStatus.AutoLogin)
            AutoConnect();
    }

    void AutoConnect()
    {

    }
}