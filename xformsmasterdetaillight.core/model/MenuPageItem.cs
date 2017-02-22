namespace xformsmasterdetaillight.core.core.model
{
    public enum MenuItem
    {
        Page1,
        Page2,
        Page3,
    }

    public class MenuPageItem
    {
        public string Title { get; set; }

        public MenuItem MenuItem { get; set; }

        public MenuPageItem()
        {
            MenuItem = MenuItem.Page1;
        }
    }
}
