using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MFM.CI.Implementation;
using Wool.Test.Glossary.Domain.Contacts;
using Wool.Test.Glossary.Data.Entities;

namespace MFM.CI.WebApi
{
    [Produces("application/json")]
    [Route("api/GlossaryTerm")]
    public class GlossaryTermController : Controller
    {
        private readonly IGlossaryTermDomainManager _glossaryTermDomainManager;

        public GlossaryTermController(IGlossaryTermDomainManager glossaryTermDomainManager)
        {
            _glossaryTermDomainManager = glossaryTermDomainManager;
        }

        [HttpGet, Route("getall")]
        public async Task<ListResult> GetAllPalindromes()
        {
            try
            {
                return await Task.FromResult(new ListResult() {
                    GlossaryTerms = await _glossaryTermDomainManager.GetAll(),
                    Message = "Terms loaded successfully",
                    Success = true
                });
            }
            catch (Exception ex)
            {
                return new ListResult()
                {
                    Message = ex.Message,
                    Success = false
                };
            }
        }

        [HttpPost, Route("save")]
        public async Task<ListResult> Save(GlossaryTerm glossaryTerm)
        {
            try
            {
                await _glossaryTermDomainManager.Save(glossaryTerm);
                return await Task.FromResult(new ListResult()
                {
                    Message = "Term saved successfully",
                    Success = true
                });
            }
            catch (Exception ex)
            {
                return new ListResult()
                {
                    Message = ex.Message,
                    Success = false
                };
            }
        }

        [HttpPost, Route("delete")]
        public async Task<ListResult> Delete(GlossaryTerm glossaryTerm)
        {
            try
            {
                await _glossaryTermDomainManager.Delete(glossaryTerm);
                return await Task.FromResult(new ListResult()
                {
                    Message = "Term deleted successfully",
                    Success = true
                });
            }
            catch (Exception ex)
            {
                return new ListResult()
                {
                    Message = ex.Message,
                    Success = false
                };
            }
        }
    }
}