﻿namespace Prometheus
{
    /// <summary>
    /// The only purpose this serves is to warn the developer when he might be accidentally introducing
    /// new serialization-time relationships. The serialization code is very tied to the text format and
    /// not intended to be a generic serialization mechanism.
    /// </summary>
    /// <remarks>
    /// Public only for testing purposes.
    /// </remarks>
    public interface IMetricsSerializer
    {
        /// <summary>
        /// Writes the lines that declare the metric family.
        /// </summary>
        void WriteFamilyDeclaration(byte[][] headerLines);

        /// <summary>
        /// Writes a single metric in a metric family.
        /// </summary>
        void WriteMetric(byte[] identifier, double value);

        /// <summary>
        /// Writes a single metric in a metric family with timestamp.
        /// </summary>
        void WriteMetric(byte[] identifier, double value, long timestamp);

        /// <summary>
        /// Writes a single metric in a metric family with timestamp preconverted.
        /// </summary>
        void WriteMetric(byte[] identifier, double value, byte[] timestamp, int numBytes);
    }
}
