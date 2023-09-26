using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Base.Binary.Precision.Single.From.System;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;
using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Empty.With.Size;

public sealed class System : Map::Envelope
{
	public System
	(
		Any<System::Single> size
	) : base
	(
		new Map::Empty.With.Size.Tumbleweed(
			new One(size))
	)
	{
	}
}