using Tumbleweed.Scalar.Function;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class MeshOfFunction : MeshEnvelope
{
	public MeshOfFunction(Func<IMesh> function) : this
	(
		new System<IMesh>(function)
	)
	{
	}
	
	public MeshOfFunction(Tumbleweed.Subroutine.Function.Nullary.Any<IMesh> function) : base
	(
		new MeshOfScalar(
			new Tumbleweed.Scalar.Function.Result<IMesh>(function))
	)
	{
	}
}