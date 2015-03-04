using System;
using System.Collections.Generic;
using Nancy.Swagger.Annotations.Attributes;

namespace Nancy.Swagger.Annotations.Demo.Models
{
    public class Pet
    {
        public long Id { get; set; }
        public Category Category { get; set; }

        [SwaggerModelProperty(Required = true)]
        public string Name { get; set; }

        [SwaggerModelProperty(Required = true)]
        public List<string> PhotoUrls { get; set; }

        public List<Tag> Tags { get; set; }

        [SwaggerModelProperty(Description = "pet status in the store")]
        [SwaggerModelProperty(Enum = new[] {"available", "pending", "sold"})]
        public String Status { get; set; }
    }
}