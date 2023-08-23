using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Point = Tumbleweed.Point.Spatial;
using System = System;
using RealPoint = Tumbleweed.Point.Spatial.Implementation.Real;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Empty.With.Size;

public sealed class System : Map::Envelope
{
	public System
	(
		Point::Any<System::Single> size
	) : base
	(
		new Map::Empty.With.Size.Tumbleweed(
			new RealPoint::Base.Binary.Precision.Single.From.System.One(size))
	)
	{
	}
}