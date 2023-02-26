using Godot;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Spatials.ToGodot;

public sealed class Vector3FromSpatial : ScalarEnvelope<Vector3>
{
	public Vector3FromSpatial(ISpatial<IDecimal> spatial) : base
	(
		new ValueOfDelegate<Vector3>(() => Result(spatial))
	)
	{
	}

	private static Vector3 Result(ISpatial<IDecimal> spatial)
	{
		return new Vector3(
			new SingleFromDecimal(spatial.X).Value,
			new SingleFromDecimal(spatial.Y).Value,
			new SingleFromDecimal(spatial.Z).Value);
	}
}