using System;
using System.Collections.Generic;
using TimerPro1.custom;

using Xamarin.Forms;

namespace TimerPro1
{
    
    public partial class TimerProPage : ContentPage
    {
        TimerLogic oTimerLogic;
        bool isRunning;
        public TimerProPage()
        {
            InitializeComponent();
            oTimerLogic = new TimerLogic();
        }

        void Start_Clicked(System.Object sender, System.EventArgs e)
        {
            btnStart.IsEnabled = false;
            btnStop.IsEnabled = true;
            isRunning = true;

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>{
                if (isRunning)
                {
                    oTimerLogic.SetTickCount();
                    lblDisplay.Text = oTimerLogic.GetFormattedString();
                }
                
                return isRunning;
            });

        }

        void Stop_Clicked(System.Object sender, System.EventArgs e)
        {
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            isRunning = false;
        }

        void Reset_Clicked(System.Object sender, System.EventArgs e)
        {
            oTimerLogic.Reset();
            lblDisplay.Text = oTimerLogic.GetFormattedString();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
            lblDisplay.Text = "00:00:00";
        }
    }
}
