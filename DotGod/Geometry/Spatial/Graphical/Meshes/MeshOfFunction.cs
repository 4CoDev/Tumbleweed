using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace DotGod.Geometry.Spatial.Graphical.Meshes;

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