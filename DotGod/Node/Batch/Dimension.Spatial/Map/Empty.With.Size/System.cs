using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Real.Base.Binary.Precision.Single.From.System;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;

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