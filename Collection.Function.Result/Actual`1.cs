using System.Collections;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Collection.Function.Result;

public sealed class Actual<T> : ICollection<T>
{
	public Actual
	(
		System::Func<ICollection<T>> function
	) : this
	(
		new Function::From.System
			<ICollection<T>>
			(function)
	)
	{
	}
	
	public Actual
	(
		Function::Any<ICollection<T>> function
	)
	{
		this.function = function;
	}

	public IEnumerator<T> GetEnumerator() =>
		function.Result.GetEnumerator();
	
	IEnumerator IEnumerable.GetEnumerator() =>
		GetEnumerator();

	public void Add(T item) =>
		function.Result.Add(item);

	public void Clear() =>
		function.Result.Clear();

	public System::Boolean Contains(T item) =>
		function.Result.Contains(item);

	public void CopyTo(T[] array, Int32 arrayIndex) =>
		function.Result.CopyTo(array, arrayIndex);

	public System::Boolean Remove(T item) =>
		function.Result.Remove(item);

	public Int32 Count =>
		function.Result.Count;

	public System::Boolean IsReadOnly =>
		function.Result.IsReadOnly;

	private readonly Function::Any<ICollection<T>> function;
}