using Xamarin.Forms;
using System;


namespace ScrollViewFormatting
{
    public partial class ScrollViewFormattingPage : ContentPage
    {
        public ScrollViewFormattingPage()
        {
            InitializeComponent();

            ////Define UI
            //AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            //RelativeLayout relativeLayout = new RelativeLayout();
            //ScrollView scrollView = new ScrollView();
            //BoxView scrollBox = new BoxView();
            //StackLayout stackView = new StackLayout();
            //Label stackLabel = new Label();
            //Button myButton = new Button();

            ////Format UI
            //scrollBox.BackgroundColor = Color.Yellow;
            //scrollBox.HeightRequest = 2000;
            //scrollBox.HorizontalOptions = LayoutOptions.Fill;

            //stackLabel.Text = "Sample Text...";
            //stackLabel.TextColor = Color.Black;
            //stackLabel.BackgroundColor = Color.LimeGreen;

            //stackView.Padding = new Thickness(10, 10, 10, 10);
            //stackView.Spacing = 20;

            //stackView.Children.Add(CreateLabel());

            ////Add alot of labels to the stack view (so the stackview's height is greater than the screens)
            //for (int i = 1; i < 30; i++) {
            //    stackView.Children.Add(CreateLabel());
            //}

            //scrollView.Content = stackView;

            ////Add scrollview to relative layout
            //relativeLayout.Children.Add(scrollView,
            //    xConstraint: Constraint.Constant(0),
            //    yConstraint: Constraint.Constant(0),
            //    widthConstraint: Constraint.RelativeToParent((parent) => { return parent.Width; }),
            //    heightConstraint: Constraint.RelativeToParent((parent) => { return parent.Height; }));

            ////Format button
            //myButton.Text = "Press Me!";
            //myButton.BackgroundColor = Color.Black;
            //myButton.TextColor = Color.White;
            //myButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
            //myButton.VerticalOptions = LayoutOptions.CenterAndExpand;
            //myButton.WidthRequest = 200;
            //AbsoluteLayout.SetLayoutBounds(myButton, new Rectangle(0.5, 0.95, 200, 50));
            //AbsoluteLayout.SetLayoutFlags(myButton, AbsoluteLayoutFlags.PositionProportional);

            ////Add views to layout & set as our view
            //absoluteLayout.Children.Add(relativeLayout);
            //absoluteLayout.Children.Add(myButton);

            //Content = absoluteLayout;
        }

        //Helper method to create alot of labels
        public Label CreateLabel() {

            Label localLabel = new Label();
            localLabel.Text = "Sample Text...";
            localLabel.TextColor = Color.Black;
            localLabel.BackgroundColor = Color.LimeGreen;

            return localLabel;
        }
    }
}
