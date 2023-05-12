using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Real.Binaries.ToSystem.Singles;
using Tumbleweed.Numbers.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Numbers.Real.Spatials.ToGodot;

public sealed class Vector3FromSpatial : ScalarEnvelope<Vector3>
{
	public Vector3FromSpatial(ISpatial<IReal> spatial) : base
	(
		new ResultOfFunction<Vector3>(() => Result(spatial))
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