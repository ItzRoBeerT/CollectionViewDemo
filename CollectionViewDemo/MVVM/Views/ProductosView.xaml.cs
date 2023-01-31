using CollectionViewDemo.MVVM.ViewModels;

namespace CollectionViewDemo.MVVM.Views;

public partial class ProductosView : ContentPage
{
	public ProductosView()
	{
		InitializeComponent();
        BindingContext = new DataViewModel();
    }
}