import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'tech_bytes_demo',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44391/',
    redirectUri: baseUrl,
    clientId: 'tech_bytes_demo_App',
    responseType: 'code',
    scope: 'offline_access tech_bytes_demo',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44391',
      rootNamespace: 'tech_bytes_demo',
    },
  },
} as Environment;
