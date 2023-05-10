using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Meshes;

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