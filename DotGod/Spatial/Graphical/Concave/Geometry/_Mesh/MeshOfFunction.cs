using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh;

public sealed class MeshOfFunction : MeshEnvelope
{
	public MeshOfFunction(Func<IMesh> function) : this
	(
		new FunctionFromSystem<IMesh>(function)
	)
	{
	}
	
	public MeshOfFunction(IFunction<IMesh> function) : base
	(
		new MeshOfScalar(
			new ResultOfFunction<IMesh>(function))
	)
	{
	}
}