import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'NewsApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44319/',
    redirectUri: baseUrl,
    clientId: 'NewsApp_App',
    responseType: 'code',
    scope: 'offline_access NewsApp',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44319',
      rootNamespace: 'NewsApp',
    },
  },
} as Environment;
