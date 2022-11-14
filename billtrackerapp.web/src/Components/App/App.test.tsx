import React from 'react';
import { render } from '@testing-library/react';
import App from './App';


test('renders learn react link', () => {
  const { getByText } = render(<App />);
  const elem = getByText(/Bill Tracker App/i);
  expect(elem).not.toBeNull();  //.toBeInTheDocument();
});
