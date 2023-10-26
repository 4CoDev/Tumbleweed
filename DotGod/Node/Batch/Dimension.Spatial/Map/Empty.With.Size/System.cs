using Godot;
using Vector = Tumbleweed.Mathematics.Vector.Spatial;
using Map = DotGod.Node.Batch.Dimension.Spatial.Map;

using System = System;

namespace DotGod.Node.Batch.Dimension.Spatial.Map.Empty.With.Size;

public sealed class System : Map::Envelope
{
	public System
	(
		Vector::Generic.Any<System::Single> size
	) : base
	(
		new Map::Empty.With.Size.Tumbleweed(
			new Vector::Real.Base.Binary.Precision.Single.From.System.One(size))
	)
	{
	}
}