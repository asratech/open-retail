﻿/**
 * Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 *
 * The latest version of this file can be found at https://github.com/rudi-krsoftware/open-retail
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenRetail.Model.Report
{
    public class ReportKasbonDetail
    {
        public string karyawan_id { get; set; }
        public string nama_karyawan { get; set; }
        public DateTime tanggal_kasbon { get; set; }
        public string nota_kasbon { get; set; }
        public double jumlah_kasbon { get; set; }
        public double total_pelunasan { get; set; }

        public double sisa
        {
            get { return jumlah_kasbon - total_pelunasan; }
        }

        public string keterangan_kasbon { get; set; }

        public DateTime tanggal_pembayaran { get; set; }
        public string nota_pembayaran { get; set; }
        public double jumlah_pembayaran { get; set; }
        public string keterangan_pembayaran { get; set; }
    }
}
