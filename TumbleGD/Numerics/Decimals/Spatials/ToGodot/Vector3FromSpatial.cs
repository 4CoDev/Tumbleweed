using Godot;
using Tumbleweed.Numerics.Binaries.ToSystem.Singles;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Numerics.Decimals.Spatials.ToGodot;

public sealed class Vector3FromSpatial : ScalarEnvelope<Vector3>
{
	public Vector3FromSpatial(ISpatial<IFractional> spatial) : base
	(
		new ValueOfFunction<Vector3>(() => Result(spatial))
	)
	{
	}

	private static Vector3 Result(ISpatial<IFractional> spatial)
	{
		return new Vector3(
			new SingleFromFractional(spatial.X).Value,
			new SingleFromFractional(spatial.Y).Value,
			new SingleFromFractional(spatial.Z).Value);
	}
}