﻿// Decompiled with JetBrains decompiler
// Type: Hero_Designer.frmAbout
// Assembly: Hero Designer, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 971EB14D-7E2B-4ADC-89DF-A9C8225AA28C
// Assembly location: C:\Users\Xbass\Desktop\Hero Designer.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using midsControls;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hero_Designer
{
  public class frmAbout : Form
  {
    [AccessedThroughProperty("ibClose")]
    private ImageButton _ibClose;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("lblDBDate")]
    private Label _lblDBDate;
    [AccessedThroughProperty("lblDBIssue")]
    private Label _lblDBIssue;
    [AccessedThroughProperty("lblDonate")]
    private Label _lblDonate;
    [AccessedThroughProperty("lblEmail")]
    private Label _lblEmail;
    [AccessedThroughProperty("lblLegal")]
    private Label _lblLegal;
    [AccessedThroughProperty("lblVersion")]
    private Label _lblVersion;
    [AccessedThroughProperty("lblWebPage")]
    private Label _lblWebPage;
    [AccessedThroughProperty("pbBackground")]
    private PictureBox _pbBackground;
    [AccessedThroughProperty("tTip")]
    private ToolTip _tTip;
    private IContainer components;
    private Point mouse_offset;

    internal virtual ImageButton ibClose
    {
      get
      {
        return this._ibClose;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ImageButton.ButtonClickedEventHandler clickedEventHandler = new ImageButton.ButtonClickedEventHandler(this.ibClose_ButtonClicked);
        if (this._ibClose != null)
          this._ibClose.ButtonClicked -= clickedEventHandler;
        this._ibClose = value;
        if (this._ibClose == null)
          return;
        this._ibClose.ButtonClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label1 = value;
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label3 = value;
      }
    }

    internal virtual Label Label4
    {
      get
      {
        return this._Label4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label4 = value;
      }
    }

    internal virtual Label Label5
    {
      get
      {
        return this._Label5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._Label5 = value;
      }
    }

    internal virtual Label lblDBDate
    {
      get
      {
        return this._lblDBDate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblDBDate = value;
      }
    }

    internal virtual Label lblDBIssue
    {
      get
      {
        return this._lblDBIssue;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblDBIssue = value;
      }
    }

    internal virtual Label lblDonate
    {
      get
      {
        return this._lblDonate;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblDonate_Click);
        if (this._lblDonate != null)
          this._lblDonate.Click -= eventHandler;
        this._lblDonate = value;
        if (this._lblDonate == null)
          return;
        this._lblDonate.Click += eventHandler;
      }
    }

    internal virtual Label lblEmail
    {
      get
      {
        return this._lblEmail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblEmail_Click);
        if (this._lblEmail != null)
          this._lblEmail.Click -= eventHandler;
        this._lblEmail = value;
        if (this._lblEmail == null)
          return;
        this._lblEmail.Click += eventHandler;
      }
    }

    internal virtual Label lblLegal
    {
      get
      {
        return this._lblLegal;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblLegal = value;
      }
    }

    internal virtual Label lblVersion
    {
      get
      {
        return this._lblVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._lblVersion = value;
      }
    }

    internal virtual Label lblWebPage
    {
      get
      {
        return this._lblWebPage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.lblWebPage_Click);
        if (this._lblWebPage != null)
          this._lblWebPage.Click -= eventHandler;
        this._lblWebPage = value;
        if (this._lblWebPage == null)
          return;
        this._lblWebPage.Click += eventHandler;
      }
    }

    internal virtual PictureBox pbBackground
    {
      get
      {
        return this._pbBackground;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.PictureBox1_MouseMove);
        MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.PictureBox1_MouseDown);
        if (this._pbBackground != null)
        {
          this._pbBackground.MouseMove -= mouseEventHandler1;
          this._pbBackground.MouseDown -= mouseEventHandler2;
        }
        this._pbBackground = value;
        if (this._pbBackground == null)
          return;
        this._pbBackground.MouseMove += mouseEventHandler1;
        this._pbBackground.MouseDown += mouseEventHandler2;
      }
    }

    internal virtual ToolTip tTip
    {
      get
      {
        return this._tTip;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        this._tTip = value;
      }
    }

    public frmAbout()
    {
      this.Load += new EventHandler(this.frmAbout_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      string str = "http://www.cohplanner.com/".Replace("http://", "");
      if (str.EndsWith("/") & str.IndexOf("/") == str.Length - 1)
        str = str.Substring(0, str.Length - 1);
      this.lblWebPage.Text = str;
      this.lblVersion.Text = Strings.Format((object) MainModule.MidsController.HeroDesignerVersion, "#0.0####");
      this.lblDBIssue.Text = Conversions.ToString(DatabaseAPI.Database.Issue);
      this.lblDBDate.Text = Strings.Format((object) DatabaseAPI.Database.Version, "#0.0####") + " (" + Strings.Format((object) DatabaseAPI.Database.Date, "dd/MMM/yyyy") + ")";
    }

    private void ibClose_ButtonClicked()
    {
      this.Close();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // frmAbout
            // 
            this.ClientSize = new System.Drawing.Size(511, 372);
            this.Name = "frmAbout";
            this.Load += new System.EventHandler(this.FrmAbout_Load_1);
            this.ResumeLayout(false);

    }

    private void lblDonate_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.Donate();
    }

    private void lblEmail_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.MailMe();
    }

    private void lblWebPage_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.GoToCoHPlanner();
    }

    private void pbPayPal_Click(object sender, EventArgs e)
    {
      clsXMLUpdate.Donate();
    }

    private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
      this.mouse_offset = new Point(-e.X, -e.Y);
    }

    private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      Point mousePosition = Control.MousePosition;
      mousePosition.Offset(this.mouse_offset.X, this.mouse_offset.Y);
      this.Location = mousePosition;
    }

        private void FrmAbout_Load_1(object sender, EventArgs e)
        {

        }
    }
}