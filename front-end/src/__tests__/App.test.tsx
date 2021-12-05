import React from 'react';
import { render, screen } from '@testing-library/react';
import App from '../App';

test('renders learn react link', () => {
  render(<App />);
  const linkElement = screen.getByText(/learn react/i);
  expect(linkElement).toBeInTheDocument();
});

test('renders learn react link2', () => {
  render(<App />);
  const linkElement = screen.getByText(/Segue oque precisa ser feito/i);
  expect(linkElement).toBeInTheDocument();
});

test('renders learn react link3', () => {
  render(<App />);
  const linkElement = screen.getByText(/id, nome, poder(valor), pontoFraco(dano)/i);
  expect(linkElement).toBeInTheDocument();
});

test('renders learn react link4', () => {
  render(<App />);
  const linkElement = screen.getByText(/id: string<br\/>/i);
  expect(linkElement).toBeInTheDocument();
});

test('renders learn react link5', () => {
  render(<App />);
  const linkElement = screen.getByText(/learn react/i);
  expect(linkElement).toBeInTheDocument();
});
