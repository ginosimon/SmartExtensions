﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace SmartExtensions
{
    public static class XmlExtensions
    {
        /// <summary>
        /// Merge two XMLs into one
        /// </summary>
        /// <param name="thisXml">XML</param>
        /// <param name="otherXml">Another XML</param>
        /// <returns></returns>
        public static XmlDocument AppendXml(this XmlDocument thisXml, XmlDocument otherXml)
        {
            foreach (XmlNode node in otherXml.DocumentElement.ChildNodes)
            {
                XmlNode imported = thisXml.ImportNode(node, true);
                thisXml.DocumentElement.AppendChild(imported);
            }

            return thisXml;
        }

        public static XmlDocument AppendXmls(this XmlDocument xmlDoc, params XmlDocument[] xmls)
        {

            foreach (var doc in xmls)
            {
                if (doc.DocumentElement == null || doc.DocumentElement.ChildNodes == null)
                {
                    continue;
                }

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    XmlNode imported = xmlDoc.ImportNode(node, true);
                    xmlDoc.DocumentElement.AppendChild(imported);
                }
            }

            return xmlDoc;
        }
    }
}
