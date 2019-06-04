using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.EverlyticPush;
using Xamarin.Forms;

namespace EverlyticPushXamarinSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void HandleSubscribeClicked(object sender, System.EventArgs e)
        {

            // Result handling is optional. In this case we simply display an
            // alert with the status of the subscription, and a brief message.

            Everlytic.Instance.Subscribe(subscriberEmailAddress.Text, result =>
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var message = result.IsSuccessful ? "Subscribe Success" : result.Exception.Message;
                    await DisplayAlert("Subscribe Result", message, "Close");
                });
                    
            });
        }

        void OtherSdkMethods()
        {
            // Check if a subscription already exists
            var isSubscribed = Everlytic.Instance.IsContactSubscribed();

            // Unsubscribes the currently subscribed user
            Everlytic.Instance.Unsubscribe((result) => { });

            // Retrieves the notification history for the device
            Everlytic.Instance.GetNotificationHistory((notifications) => { });
        }
    }
}
