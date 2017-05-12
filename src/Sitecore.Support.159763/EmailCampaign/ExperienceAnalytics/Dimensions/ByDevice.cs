using System;
using System.Collections.Generic;
using System.Reflection;
using Sitecore.Analytics.Aggregation.Data.Model;
using Sitecore.Analytics.Model;
using Sitecore.CES.DeviceDetection;
using Sitecore.Diagnostics;
using Sitecore.EmailCampaign.ExperienceAnalytics.Dimensions;
using Sitecore.ExM.Framework.Diagnostics;
using Sitecore.ExperienceAnalytics.Aggregation.Data.Model;
using Sitecore.ExperienceAnalytics.Aggregation.Dimensions;

namespace Sitecore.Support.EmailCampaign.ExperienceAnalytics.Dimensions
{

  internal class ByDevice : DimensionBase
  {
    public ByDevice(Guid dimensionId) : base(dimensionId) { }
    public override IEnumerable<DimensionData> GetData(IVisitAggregationContext context)
    {
      if (DeviceDetectionManager.IsEnabled)
        Log.Warn("Sitecore.support.159763: Device Detection is enabled, please remove the patch by disabling the Sitecore.Support.159763.config file.", this);
      return new List<DimensionData>();
    }
  }
}
