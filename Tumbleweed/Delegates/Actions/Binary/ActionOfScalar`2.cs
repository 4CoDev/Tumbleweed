using Tumbleweed.Scalars;

namespace Tumbleweed.Delegates.Actions.Binary;

public sealed class ActionOfScalar<T1, T2> : IBinaryAction<T1, T2>
{
	public ActionOfScalar
	(
		IScalar<IBinaryAction<T1, T2>> scalar
	)
	{
		this.scalar = scalar;
	}
	
	public void Invoke(T1 parameter1, T2 parameter2) =>
		scalar.Value.Invoke(parameter1, parameter2);
	
	private readonly IScalar<IBinaryAction<T1, T2>> scalar;
}