using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Numerics.Decimals.Spatials.ToGodot;

public sealed class Vector3FromSpatial : ScalarEnvelope<Vector3>
{
	public Vector3FromSpatial(ISpatial<IReal> spatial) : base
	(
		new ValueOfFunction<Vector3>(() => Result(spatial))
	)
	{
	}

	private static Vector3 Result(ISpatial<IReal> spatial)
	{
		return new Vector3(
			new SingleFromReal(spatial.X).Value,
			new SingleFromReal(spatial.Y).Value,
			new SingleFromReal(spatial.Z).Value);
	}
}