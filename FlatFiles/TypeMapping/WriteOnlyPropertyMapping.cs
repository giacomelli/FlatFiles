﻿namespace FlatFiles.TypeMapping
{
    /// <summary>
    /// Represents the mapping from a type property to a WriteOnly column.
    /// </summary>
    public interface IWriteOnlyPropertyMapping
    {
        /// <summary>
        /// Gets the name given to the read-only mapping.
        /// </summary>
        string Name { get; }
    }

    internal sealed class WriteOnlyPropertyMapping : IWriteOnlyPropertyMapping, IMemberMapping
    {
        public WriteOnlyPropertyMapping(IColumnDefinition column, string name, int fileIndex, int workIndex)
        {
            ColumnDefinition = column;
            Name = name;
            FileIndex = fileIndex;
            WorkIndex = workIndex;
        }

        public string Name { get; }

        IMemberAccessor IMemberMapping.Member => null;

        public IColumnDefinition ColumnDefinition { get; }

        public int FileIndex { get; }

        public int WorkIndex { get; }
    }
}
