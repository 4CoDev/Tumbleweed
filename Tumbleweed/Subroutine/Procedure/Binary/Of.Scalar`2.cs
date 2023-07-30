// ReSharper disable once CheckNamespace

using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Subroutine.Procedure.Binary.Of;

public sealed class Scalar<T1, T2> : Binary.Any<T1, T2>
{
	public Scalar(Any<Binary.Any<T1, T2>> scalar) =>
		this.scalar = scalar;
	
	public void InvokeWith(T1 first, T2 second) =>
		scalar.Value.InvokeWith(first, second);
	
	private readonly Any<Binary.Any<T1, T2>> scalar;
}