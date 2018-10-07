﻿using HttPlaceholder.Models;
using HttPlaceholder.Models.Enums;
using HttPlaceholder.Services;
using HttPlaceholder.Utilities;

namespace HttPlaceholder.BusinessLogic.Implementations.ConditionCheckers
{
    public class PathConditionChecker : IConditionChecker
    {
        private readonly IHttpContextService _httpContextService;

        public PathConditionChecker(IHttpContextService httpContextService)
        {
            _httpContextService = httpContextService;
        }

        public ConditionCheckResultModel Validate(string stubId, StubConditionsModel conditions)
        {
            var result = new ConditionCheckResultModel();
            string pathCondition = conditions?.Url?.Path;
            if (!string.IsNullOrEmpty(pathCondition))
            {
                string path = _httpContextService.Path;
                if (StringHelper.IsRegexMatchOrSubstring(path, pathCondition))
                {
                    // The path matches the provided regex. Add the stub ID to the resulting list.
                    result.ConditionValidation = ConditionValidationType.Valid;
                }
                else
                {
                    result.Log = $"Condition '{pathCondition}' did not pass for request.";
                    result.ConditionValidation = ConditionValidationType.Invalid;
                }
            }

            return result;
        }
    }
}