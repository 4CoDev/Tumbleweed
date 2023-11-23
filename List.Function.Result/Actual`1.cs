using System.Collections;
using System = System;
using Function = Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.List.Function.Result;

public sealed class Actual<T> : IList<T>
{
	public Actual
	(
		Function::Any<IList<T>> function
	)
	{
		this.function = function;
	}
	
	public IEnumerator<T> GetEnumerator() =>
		function.Result.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() =>
		function.Result.GetEnumerator();

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

	public Int32 IndexOf(T item) =>
		function.Result.IndexOf(item);

	public void Insert(Int32 index, T item) =>
		function.Result.Insert(index, item);

	public void RemoveAt(Int32 index) =>
		function.Result.RemoveAt(index);

	public T this[Int32 index]
	{
		get => function.Result[index];
		set => function.Result[index] = value;
	}

	private readonly Function::Any<IList<T>> function;
}