using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class DifferenceOfSpatials : SpatialEnvelope<IReal>
{
	public DifferenceOfSpatials
	(
		params ISpatial<IReal>[] spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}

	public DifferenceOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}
	
	public DifferenceOfSpatials
	(
		ICollection<ISpatial<IReal>> spatials
	) : base
	(
		new SpatialWithCoordinates<IReal>(
			new DifferenceOfReals(new XOfSpatials(spatials)),
			new DifferenceOfReals(new YOfSpatials(spatials)),
			new DifferenceOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}