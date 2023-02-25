using CrawlDataUniversity.Data;
using CrawlDataUniversity.Data.Entities;
using CrawlDataUniversity.VIewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace CrawlDataUniversity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrawlersController : ControllerBase
    {
        protected readonly IHttpClientFactory _httpClientFactory;
        private readonly ApplicationDbContext _context;
        public CrawlersController(IHttpClientFactory httpClientFactory, ApplicationDbContext context)
        {
            _httpClientFactory = httpClientFactory;
            _context = context;
        }

        //[HttpGet("province")]
        //public async Task<IActionResult> GetProvinces()
        //{
        //    var url = "https://api.tsdh.online/api/provinces";
        //    var client = _httpClientFactory.CreateClient();
        //    var province = await GetAsync<List<ProvinceVM>>(url, client);
        //    if (!_context.Provinces.Any())
        //    {
        //        var data = new List<Province>();
        //        foreach (var item in province)
        //        {
        //            var dataItem = new Province()
        //            {
        //                Id = item.Id,
        //                Name = item.Name,
        //                Slug = item.Slug,
        //                Type = item.Type,
        //                Name_with_type = item.Name_with_type,
        //                Code = item.Code,
        //                Domain = item.Domain
        //            };
        //            data.Add(dataItem);
        //        }
        //        await _context.Provinces.AddRangeAsync(data);
        //        await _context.SaveChangesAsync();
        //    }

        //    return Ok(province);
        //}
        [HttpGet("field")]
        public async Task<IActionResult> GetFields()
        {
            var url = "https://api.tsdh.online/api/group-major-interest/major-group";
            var client = _httpClientFactory.CreateClient();
            var fields = await GetAsync<List<FieldVM>>(url, client);
            if (!_context.Fields.Any())
            {
                var data = new List<Field>();
                foreach (var item in fields)
                {
                    var dataItem = new Field()
                    {
                        Id = item.Id,
                        Name = item.Name,
                    };

                    data.Add(dataItem);
                }
                await _context.Fields.AddRangeAsync(data);
                await _context.SaveChangesAsync();
            }
            return Ok(fields);
        }
        //[HttpGet("major-gr")]
        //public async Task<IActionResult> GetMajorGr()
        //{
        //    var url = "https://api.tsdh.online/api/majors/majors-3";
        //    var client = _httpClientFactory.CreateClient();
        //    var mgr = await GetAsync<List<MajorVM>>(url, client);
        //    if (!_context.MajorGroups.Any())
        //    {
        //        var data = new List<MajorGroup>();
        //        foreach (var item in mgr)
        //        {
        //            var dataItem = new MajorGroup()
        //            {
        //                Id = item.Id,
        //                Name = item.Name,
        //                Code = item.Code,
        //                FieldId = 1,
        //            };

        //            data.Add(dataItem);
        //        }
        //        await _context.MajorGroups.AddRangeAsync(data);
        //        await _context.SaveChangesAsync();
        //    }
        //    return Ok(mgr);
        //}
        //[HttpGet("major")]
        //public async Task<IActionResult> GetMajors()
        //{
        //    var url = "https://api.tsdh.online/api/majors/majors-7";
        //    var client = _httpClientFactory.CreateClient();
        //    var majors = await GetAsync<List<Major>>(url, client);
        //    var data = new List<Major>();
        //    foreach (var item in majors)
        //    {
        //        var dataItem = new Major()
        //        {
        //            Id = item.Id,
        //            Name = item.Name,
        //            Code = item.Code,
        //            MajorGroupId = 1
        //        };
        //        data.Add(dataItem);
        //    }
        //    await _context.Majors.AddRangeAsync(data);
        //    await _context.SaveChangesAsync();
        //    return Ok("success");
        //}
        //[HttpGet("uni-major")]
        //public async Task<IActionResult> GetUniMajor()
        //{
        //    int from = 0, range = 10;
        //    while (from < 5490)
        //    {
        //        string majorIdList = GenerateMajorIdList(from, range);
        //        var url = "https://api.tsdh.online/api/university-majors/suitable-majors?majorIdList=" + majorIdList;
        //        var client = _httpClientFactory.CreateClient();
        //        var uniMajors = await GetAsync<List<UniversityMajorVM>>(url, client);
        //        var data = new List<UniversityMajor>();
        //        foreach (var item in uniMajors)
        //        {
        //            var dataItem = new UniversityMajor()
        //            {
        //                Id = item.Id,
        //                Name = item.Name,
        //                Code = item.Code,
        //            };
        //            dataItem.Benchmarks = item.Benchmarks.Select(x => new Benchmark
        //            {
        //                Id = x.Id,
        //                CurrentPoint = x.CurrentPoint,
        //                PrePoint = x.PrePoint,
        //                Type = (Data.Entities.Type)x.type,
        //                Blocks = string.Join(",", x.Blocks)
        //            }).ToList();
        //            data.Add(dataItem);
        //        }
        //        await _context.UniversityMajors.AddRangeAsync(data);
        //        await _context.SaveChangesAsync();
        //        from += 10;
        //    }

        //    return Ok();
        //}
        //[HttpGet("uni")]
        //public async Task<IActionResult> GetUniversity()
        //{
        //    int page = 1;
        //    while (page < 23)
        //    {
        //        var url = "https://api.tsdh.online/api/group-major-interest/university/0?limit=10&page=" + page;
        //        var client = _httpClientFactory.CreateClient();
        //        var universities = await GetAsync<PagedResult<UniversityVM>>(url, client);
        //        var data = new List<University>();
        //        foreach (var item in universities.universities)
        //        {
        //            var dataItem = new University()
        //            {
        //                Id = item.Id,
        //                Name = item.UniName,
        //                Code = item.UniCode,
        //                ImagePath = item.UniImage,
        //                ProvinceId = 1
        //            };
        //            data.Add(dataItem);
        //            foreach (var major in item.Majors)
        //            {
        //                var UniMajor = await _context.UniversityMajors.FindAsync(major.Id);
        //                if (UniMajor != null)
        //                    UniMajor.UniversityId = item.Id;
        //            }
        //        }
        //        await _context.Universities.AddRangeAsync(data);
        //        await _context.SaveChangesAsync();
        //        page++;
        //    }


        //    return Ok("success");
        //}
        [HttpGet("uniPhone")]
        public async Task<IActionResult> GetUniphone()
        {
            var url = "https://api.tsdh.online/api/universities/admissions-infor?code=";
            var i = 0;
            var uniCodes = _context.Universities.Where(x => x.Code == "QHL").ToList();
            foreach (var item in uniCodes)
            {
       
                var client = _httpClientFactory.CreateClient();
                var response = await client.GetAsync(url + item);
                var body = await response.Content.ReadAsStringAsync();

                var phone = GetPhone(body);
                var facebook = GetFacebook(body);


               // var uni = await _context.Universities.FirstOrDefaultAsync(x => x.Code == item);
                //uni.Phone = phone;
                //uni.Facebook = facebook;
                await _context.SaveChangesAsync();
                i++;
            }
          

            return Ok(i);
        }
        private string GetPhone(string body)
        {
            if (body.Length < 20) return "";
            var start = body.IndexOf("SĐT");
            if (start == -1) start = body.IndexOf("điện thoại");
            if (start == -1) return "";
            body = body.Substring(start + 5);
            var end = body.IndexOf("</span");
            var phone = body.Substring(0, end );
            return phone;
        }
        private string GetFacebook(string body)
        {
            if (body.Length < 20) return "";
            var start = body.IndexOf("Facebook");
            if (start == -1) return "";
            body = body.Substring(start + 9);
            var end = body.IndexOf("</span");
            var phone = body.Substring(0, end);
            return phone;
        }
        [HttpGet("uni-address")]
        public async Task<IActionResult> GetUniversity()
        {
            //count = 395
            int page = 1;
            while (page < 21)
            {
                var url = "https://api.tsdh.online/api/universities/adv-search?limit=20&page=" + page;
                var client = _httpClientFactory.CreateClient();
                var universities = await GetAsync<PagedResult<UniversityAddressVM>>(url, client);
                foreach (var item in universities.universities)
                {
                    var uni = await _context.Universities.FindAsync(item.Id);
                    if (uni != null)
                    {
                        uni.Website = item.Website;
                        uni.Rating = item.Rating;
                        uni.Email = item.Email;
                        foreach (var add in item.Addresses)
                        {
                            var province = await _context.Provinces.FirstOrDefaultAsync(x => x.Name.Contains(add.Province));
                            if (province == null) continue;
                 
                            var address = new Address
                            {
                                Id = add.Id,
                                Display = add.Display,
                                Side = add.Side,
                                Street = add.Street,
                                ProvinceId = province.Id,
                                District = add.District,
                                UniversityId = item.Id
                            };
                            _context.Addresses.Add(address);
                        }
                        _context.Universities.Update(uni);
                        await _context.SaveChangesAsync();
                    }

                }

                page++;
            }


            return Ok("success");
        }


        protected async Task<TResponse> GetAsync<TResponse>(string url, HttpClient client)
        {
            var response = await client.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TResponse myDeserializedObjList = (TResponse)JsonConvert.DeserializeObject(body,
                    typeof(TResponse));
                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<TResponse>(body);
        }
        private string GenerateMajorIdList(int from, int range)
        {
            var numberList = Enumerable.Range(from, range).ToList();
            return string.Join(",", numberList);
        }
    }
}
