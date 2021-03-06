﻿using MahApps.Metro.Controls;
using Prism.Regions;

namespace PrismJPKEditor.Core.Regions
{
    public class HamburgerMenuItemCollectionRegionAdapter : RegionAdapterBase<HamburgerMenuItemCollection>
    {


        public HamburgerMenuItemCollectionRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {

        }

        protected override void Adapt(IRegion region, HamburgerMenuItemCollection regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    foreach (HamburgerMenuItemBase element in e.NewItems)
                    {
                        regionTarget.Add(element);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }
    }
}
