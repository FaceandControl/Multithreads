using System;
using System.Collections.Generic;

namespace Multithreads {
	public class Task
	{
		#region RandomDict
		static private readonly Dictionary<int, List<int>> dict_all_options_units = new Dictionary<int, List<int>>()
		{
			{ 1, new List<int> { 1, 2, 3, 4, 5 } },

			{ 2, new List<int> { 2, 3, 4, 5 } },
			{ 3, new List<int> { 1, 3, 4, 5 } },
			{ 4, new List<int> { 1, 2, 4, 5 } },
			{ 5, new List<int> { 1, 2, 3, 5 } },
			{ 6, new List<int> { 1, 2, 3, 4 } },

			{ 7, new List<int> { 1, 2, 3 } },
			{ 8, new List<int> { 1, 2, 4 } },
			{ 9, new List<int> { 1, 2, 5 } },
			{ 10, new List<int> { 1, 3, 4 } },
			{ 11, new List<int> { 1, 3, 5 } },
			{ 12, new List<int> { 1, 4, 5 } },
			{ 13, new List<int> { 2, 3, 4 } },
			{ 14, new List<int> { 2, 3, 5 } },
			{ 15, new List<int> { 2, 4, 5 } },
			{ 16, new List<int> { 3, 4, 5 } },

			{ 17, new List<int> { 1, 2 } },
			{ 18, new List<int> { 1, 3 } },
			{ 19, new List<int> { 1, 4 } },
			{ 20, new List<int> { 1, 5 } },
			{ 21, new List<int> { 2, 3 } },
			{ 22, new List<int> { 2, 4 } },
			{ 23, new List<int> { 2, 5 } },
			{ 24, new List<int> { 3, 4 } },
			{ 25, new List<int> { 3, 5 } },
			{ 26, new List<int> { 4, 5 } },

			{ 27, new List<int> { 1 } },
			{ 28, new List<int> { 2 } },
			{ 29, new List<int> { 3 } },
			{ 30, new List<int> { 4 } },
			{ 31, new List<int> { 5 } },
		};
		#endregion RandomDict

		static private int task_id_counter = 0;
		public int Task_id { get; }

		private const int lower_complexity = 10;
		private const int maximum_complexity = 200;

		private int complexity = new Random().Next(lower_complexity, maximum_complexity + 1);
		public int Complexity 
		{
			get => complexity;
			set {
				if (lower_complexity >= value && maximum_complexity <= value) {
					complexity = value;
				}
			}
		}

		private readonly List<int> available_units;

		public Task() 
		{
			available_units = GenerateAvailableUnits();
			Task_id = task_id_counter++;
		}

		public Task(int _complexity)
		{
			available_units = GenerateAvailableUnits();
			Complexity = _complexity;
			Task_id = task_id_counter++;
		}

		private List<int> GenerateAvailableUnits() {
			return dict_all_options_units[new Random().Next(1, dict_all_options_units.Count + 1)];
		}

		public bool is_unit_fits(int unit_number) {
			return available_units.Contains(unit_number);
		}
	}
}

