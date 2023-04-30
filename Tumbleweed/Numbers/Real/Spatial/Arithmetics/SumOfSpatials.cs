using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class SumOfSpatials : SpatialEnvelope<IReal>
{
	public SumOfSpatials
	(
		params ISpatial<IReal>[] spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}

	public SumOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}
	
	public SumOfSpatials
	(
		ICollection<ISpatial<IReal>> spatials
	) : base
	(
		new SpatialWithCoordinates<IReal>(
			new SumOfReals(new XOfSpatials(spatials)),
			new SumOfReals(new YOfSpatials(spatials)),
			new SumOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}