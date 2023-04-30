using Tumbleweed.Numbers.Real.Arithmetics;
using Tumbleweed.Numbers.Real.Spatial.Coordinates;
using Tumbleweed.Numbers.Spatial;

namespace Tumbleweed.Numbers.Real.Spatial.Arithmetics;

public sealed class QuotientOfSpatials : SpatialEnvelope<IReal>
{
	public QuotientOfSpatials
	(
		params ISpatial<IReal>[] spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}

	public QuotientOfSpatials
	(
		IEnumerable<ISpatial<IReal>> spatials
	) : this
	(
		new List<ISpatial<IReal>>(spatials)
	)
	{
	}
	
	public QuotientOfSpatials
	(
		ICollection<ISpatial<IReal>> spatials
	) : base
	(
		new SpatialWithCoordinates<IReal>(
			new QuotientOfReals(new XOfSpatials(spatials)),
			new QuotientOfReals(new YOfSpatials(spatials)),
			new QuotientOfReals(new ZOfSpatials(spatials)))
	)
	{
	}
}