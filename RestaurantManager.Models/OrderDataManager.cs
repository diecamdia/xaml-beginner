using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }
        List<MenuItem> menuItems;

        public List<MenuItem> MenuItems
        {
            get { return menuItems; }
            set
            {
                menuItems = value;
                this.OnPropertyChanged("MenuItems");
            }
        }

        List<MenuItem> currentlySelectedMenuItems;

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return currentlySelectedMenuItems; }
            set
            {
                currentlySelectedMenuItems = value;
                this.OnPropertyChanged("CurrentlySelectedMenuItems");
            }
        }
    }
}
