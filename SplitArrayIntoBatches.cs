namespace Extensions {
  public static class CommonExtensions {
    public static T[] GetArrayPortion < T > (T[] array, int startingIndex, int endIndex) {
      if (startingIndex > endIndex)
        throw new InvalidOperationException("The starting index must be lower than or equal to the end index.");

      return array ?
        .Skip(startingIndex)
        .Take((endIndex - startingIndex) + 1)
        .ToArray();
    }

    public static IEnumerable < T[] > SplitArrayIntoBatches < T > (T[] array, int batchSize) {
      var numberOfBatches = (int) Math.Ceiling((decimal) array.Length / batchSize);
      return SplitArrayIntoBatches(array, batchSize, numberOfBatches);
    }

    public static IEnumerable < T[] > SplitArrayIntoBatches < T > (T[] array, int batchSize, int numberOfBatches) {
      var index = 0;
      var batches = new List < T[] > ();

      for (var batchNumber = 1; batchNumber <= numberOfBatches; batchNumber++) {
        var endIndexToTake = (index + batchSize) - 1;

        if (endIndexToTake <= array.Length) {
          var currentBatch = GetArrayPortion(array, index, endIndexToTake);
          batches.Add(currentBatch);
          index += batchSize;
        } else {
          break;
        }
      }

      return batches;
    }
  }
}
