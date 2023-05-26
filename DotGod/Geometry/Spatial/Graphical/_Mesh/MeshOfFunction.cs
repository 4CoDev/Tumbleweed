using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace DotGod.Geometry.Spatial.Graphical._Mesh;

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