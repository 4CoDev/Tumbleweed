// ReSharper disable once CheckNamespace
namespace Tumbleweed.Subroutine.Procedure.Binary.Of;

public sealed class Scalar<T1, T2> : Binary.Any<T1, T2>
{
	public Scalar(Scalar.Any<Binary.Any<T1, T2>> scalar) =>
		this.scalar = scalar;
	
	public void InvokeWith(T1 first, T2 second) =>
		scalar.Value.InvokeWith(first, second);
	
	private readonly Scalar.Any<Binary.Any<T1, T2>> scalar;
}