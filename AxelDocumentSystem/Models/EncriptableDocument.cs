﻿namespace DocumentSystem.Models
{
    using DocumentSystem.Interfaces;

    public abstract class EncriptableDocument: BinaryDocument, IDocument, IEncryptable
    {
        public EncriptableDocument(string name, string content = null, long size = 0)
            : base(name, content, size)
        {
            this.IsEncrypted = false;
        }

        public bool IsEncrypted { get; private set; }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                return string.Format("{0}[encrypted]", this.GetType().Name);
            }
            else
            {
                return base.ToString();
            }
        }
    }
}
